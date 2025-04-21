﻿
using System.Text.Json;
using System.Text.RegularExpressions;
using Aspose.Cells;
using Environment = System.Environment;

public static class ExcelGenerator
{
    private static HashSet<string> _excelNames = new HashSet<string>();
    
    private enum CollectionsType
    {
        None,
        Array,
        Map
    }
    
    private class MappingData
    {
        public string TypeStr;
        public string TypeName;
        public CollectionsType CollectionsType;
        public bool AutoParentheses = false;
        
        public bool IsRefExcel;
        public string RefTypeStr;
        public string RefTypeName;

        public MappingData(string typeStr, string typeName, CollectionsType collectionsType)
        {
            TypeStr = typeStr;
            TypeName = typeName;
            CollectionsType = collectionsType;
            IsRefExcel = false;
        }
        
        public MappingData(string typeStr, string typeName, CollectionsType collectionsType, string refTypeStr, string refTypeName)
        {
            TypeStr = typeStr;
            TypeName = typeName;
            CollectionsType = collectionsType;
            IsRefExcel = true;
            RefTypeStr = refTypeStr;
            RefTypeName = refTypeName;
        }
    }

    private class ExcelData
    {
        public string TableName;
        public string OutCode;
        public List<string> ColumnNames = new List<string>();
        public Dictionary<string, MappingData> ColumnMappingData = new Dictionary<string, MappingData>();
        public Dictionary<string, Type> ColumnType = new Dictionary<string, Type>();
        public List<Dictionary<string, object>> DataList = new List<Dictionary<string, object>>();
    }
    
    /// <summary>
    /// 导出 Excel 表
    /// </summary>
    public static bool ExportExcel()
    {
        var excelPath = "excel/";
        var jsonPath = "config/";
        var codePath = "src/";
        return ExportExcel(excelPath, jsonPath, codePath);
    }
    
    /// <summary>
    /// 导出 Excel 表
    /// </summary>
    /// <param name="excelFilePath">excel文件路径</param>
    /// <param name="jsonOutPath">json配置输出路径</param>
    /// <param name="codeOutPath">代码输出路径</param>
    public static bool ExportExcel(string excelFilePath, string jsonOutPath, string codeOutPath)
    {
        _excelNames.Clear();
        Console.WriteLine("当前路径: " + Environment.CurrentDirectory);
        Console.WriteLine("excel路径: " + excelFilePath);
        Console.WriteLine("json输出路径: " + jsonOutPath);
        Console.WriteLine("cs代码输出路径: " + codeOutPath);
        try
        {
            var excelDataList = new List<ExcelData>();
            
            var directoryInfo = new DirectoryInfo(excelFilePath);
            if (directoryInfo.Exists)
            {
                var fileInfos = directoryInfo.GetFiles();
                //记录文件
                foreach (var fileInfo in fileInfos)
                {
                    if (fileInfo.Extension == ".xlsx")
                    {
                        var fileName = Path.GetFileNameWithoutExtension(fileInfo.Name).FirstToUpper();
                        _excelNames.Add(fileName);
                    }
                }

                //读取配置文件
                foreach (var fileInfo in fileInfos)
                {
                    if (fileInfo.Extension == ".xlsx")
                    {
                        if (fileInfo.Name == "ExcelConfig.xlsx")
                        {
                            throw new Exception("excel表文件名称不允许叫'ExcelConfig.xlsx'!");
                        }
                        Console.WriteLine("excel表: " + fileInfo.FullName);
                        excelDataList.Add(ReadExcel(fileInfo.FullName));
                    }
                }
            }

            Console.WriteLine($"一共检测到excel表共{excelDataList.Count}张.");
            if (excelDataList.Count == 0)
            {
                return true;
            }
            
            if (Directory.Exists(codeOutPath))
            {
                Directory.Delete(codeOutPath, true);
            }
            if (Directory.Exists(jsonOutPath))
            {
                Directory.Delete(jsonOutPath, true);
            }
            Directory.CreateDirectory(codeOutPath);
            Directory.CreateDirectory(jsonOutPath);
            
            //保存配置和代码
            foreach (var excelData in excelDataList)
            {
                File.WriteAllText(codeOutPath + "ExcelConfig_" + excelData.TableName + ".cs", excelData.OutCode);
                var config = new JsonSerializerOptions();
                config.WriteIndented = true;
                File.WriteAllText(jsonOutPath + excelData.TableName + ".json", JsonSerializer.Serialize(excelData.DataList, config));
            }
            
            //生成加载代码
            var code = GeneratorInitCode(excelDataList);
            File.WriteAllText(codeOutPath + "ExcelConfig.cs", code);
        }
        catch (Exception e)
        {
            PrintError(e.ToString());
            return false;
        }

        return true;
    }

    private static string GeneratorInitCode(List<ExcelData> excelList)
    {
        var code = $"using System;\n";
        code += $"using System.Collections.Generic;\n";
        code += $"using System.Text.Json;\n";
        code += $"using Godot;\n";
        code += $"\n";
        code += $"namespace Config;\n";
        code += $"\n";
        code += $"public static partial class ExcelConfig\n";
        code += $"{{\n";

        var fieldCode = "";
        var callFuncCode = "";
        var callInitRefFuncCode = "";
        var funcCode = "";
        var initRefFuncCode = "";
        
        foreach (var excelData in excelList)
        {
            var idName = excelData.ColumnNames[0];
            var idTypeStr = excelData.ColumnMappingData[idName].TypeStr;
            
            //---------------------------- 引用其他表处理 ----------------------------
            var hasRefColumn = false;
            var refColumnNoneCode = "";
            foreach (var columnName in excelData.ColumnNames)
            {
                var mappingData = excelData.ColumnMappingData[columnName];
                if (mappingData.IsRefExcel)
                {
                    hasRefColumn = true;
                    if (mappingData.CollectionsType == CollectionsType.None)
                    {
                        refColumnNoneCode += $"                if (!string.IsNullOrEmpty(item.__{columnName}))\n";
                        refColumnNoneCode += $"                {{\n";
                        refColumnNoneCode += $"                    item.{columnName} = {mappingData.RefTypeName}_Map[item.__{columnName}];\n";
                        refColumnNoneCode += $"                }}\n";
                    }
                    else if (mappingData.CollectionsType == CollectionsType.Array)
                    {
                        refColumnNoneCode += $"                if (item.__{columnName} != null)\n";
                        refColumnNoneCode += $"                {{\n";
                        refColumnNoneCode += $"                    item.{columnName} = new {mappingData.RefTypeName}[item.__{columnName}.Length];\n";
                        refColumnNoneCode += $"                    for (var i = 0; i < item.__{columnName}.Length; i++)\n";
                        refColumnNoneCode += $"                    {{\n";
                        refColumnNoneCode += $"                        item.{columnName}[i] = {mappingData.RefTypeName}_Map[item.__{columnName}[i]];\n";
                        refColumnNoneCode += $"                    }}\n";
                        refColumnNoneCode += $"                }}\n";
                    }
                    else
                    {
                        refColumnNoneCode += $"                if (item.__{columnName} != null)\n";
                        refColumnNoneCode += $"                {{\n";
                        refColumnNoneCode += $"                    item.{columnName} = new {mappingData.RefTypeStr}();\n";
                        refColumnNoneCode += $"                    foreach (var pair in item.__{columnName})\n";
                        refColumnNoneCode += $"                    {{\n";
                        refColumnNoneCode += $"                        item.{columnName}.Add(pair.Key, {mappingData.RefTypeName}_Map[pair.Value]);\n";
                        refColumnNoneCode += $"                    }}\n";
                        refColumnNoneCode += $"                }}\n";
                    }
                    refColumnNoneCode += $"\n";
                }
            }
            
            //----------------------------- 数据集合 ------------------------------------
            fieldCode += $"    /// <summary>\n";
            fieldCode += $"    /// {excelData.TableName}.xlsx表数据集合, 以 List 形式存储, 数据顺序与 Excel 表相同\n";
            fieldCode += $"    /// </summary>\n";
            fieldCode += $"    public static List<{excelData.TableName}> {excelData.TableName}_List {{ get; private set; }}\n";
            fieldCode += $"    /// <summary>\n";
            fieldCode += $"    /// {excelData.TableName}.xlsx表数据集合, 里 Map 形式存储, key 为 {idName}\n";
            fieldCode += $"    /// </summary>\n";
            fieldCode += $"    public static Dictionary<{idTypeStr}, {excelData.TableName}> {excelData.TableName}_Map {{ get; private set; }}\n";
            fieldCode += $"\n";
            
            //------------------------------- 初始化函数 -------------------------------------
            callFuncCode += $"        _Init{excelData.TableName}Config();\n";
            
            funcCode += $"    private static void _Init{excelData.TableName}Config()\n";
            funcCode += $"    {{\n";
            funcCode += $"        try\n";
            funcCode += $"        {{\n";
            funcCode += $"            var text = _ReadConfigAsText(\"res://resource/config/{excelData.TableName}.json\");\n";
            if (hasRefColumn) //存在引用列
            {
                funcCode += $"            {excelData.TableName}_List = new List<{excelData.TableName}>(JsonSerializer.Deserialize<List<Ref_{excelData.TableName}>>(text));\n";
            }
            else
            {
                funcCode += $"            {excelData.TableName}_List = JsonSerializer.Deserialize<List<{excelData.TableName}>>(text);\n";
            }
            funcCode += $"            {excelData.TableName}_Map = new Dictionary<{idTypeStr}, {excelData.TableName}>();\n";
            funcCode += $"            foreach (var item in {excelData.TableName}_List)\n";
            funcCode += $"            {{\n";
            funcCode += $"                {excelData.TableName}_Map.Add(item.{idName}, item);\n";
            funcCode += $"            }}\n";
            funcCode += $"        }}\n";
            funcCode += $"        catch (Exception e)\n";
            funcCode += $"        {{\n";
            funcCode += $"            GD.PrintErr(e.ToString());\n";
            funcCode += $"            throw new Exception(\"初始化表'{excelData.TableName}'失败!\");\n";
            funcCode += $"        }}\n";
            funcCode += $"    }}\n";

            
            //------------------------------- 初始化引用 ---------------------------------
            if (hasRefColumn)
            {
                callInitRefFuncCode += $"        _Init{excelData.TableName}Ref();\n";

                initRefFuncCode += $"    private static void _Init{excelData.TableName}Ref()\n";
                initRefFuncCode += $"    {{\n";
                initRefFuncCode += $"        foreach (Ref_{excelData.TableName} item in {excelData.TableName}_List)\n";
                initRefFuncCode += $"        {{\n";
                initRefFuncCode += $"            try\n";
                initRefFuncCode += $"            {{\n";
                initRefFuncCode += refColumnNoneCode;
                initRefFuncCode += $"            }}\n";
                initRefFuncCode += $"            catch (Exception e)\n";
                initRefFuncCode += $"            {{\n";
                initRefFuncCode += $"                GD.PrintErr(e.ToString());\n";
                initRefFuncCode += $"                throw new Exception(\"初始化'{excelData.TableName}'引用其他表数据失败, 当前行id: \" + item.Id);\n";
                initRefFuncCode += $"            }}\n";
                initRefFuncCode += $"        }}\n";
                initRefFuncCode += $"    }}\n";
            }
        }

        code += fieldCode;
        code += $"\n";
        code += $"    private static bool _init = false;\n";
        code += $"    /// <summary>\n";
        code += $"    /// 初始化所有配置表数据\n";
        code += $"    /// </summary>\n";
        code += $"    public static void Init()\n";
        code += $"    {{\n";
        code += $"        if (_init) return;\n";
        code += $"        _init = true;\n";
        code += $"\n";
        code += callFuncCode;
        code += $"\n";
        code += callInitRefFuncCode;
        code += $"    }}\n";
        code += funcCode;
        code += $"\n";
        code += initRefFuncCode;
        code += $"    private static string _ReadConfigAsText(string path)\n";
        code += $"    {{\n";
        code += $"        var file = FileAccess.Open(path, FileAccess.ModeFlags.Read);\n";
        code += $"        var asText = file.GetAsText();\n";
        code += $"        file.Dispose();\n";
        code += $"        return asText;\n";
        code += $"    }}\n";
        code += $"}}";
        return code;
    }
    
    private static ExcelData ReadExcel(string excelPath)
    {
        var excelData = new ExcelData();
        //文件名称
        var fileName = Path.GetFileNameWithoutExtension(excelPath).FirstToUpper();
        excelData.TableName = fileName;
        //输出代码
        var outStr = $"using System.Text.Json.Serialization;\n";
        outStr += $"using System.Collections.Generic;\n\n";
        outStr += $"namespace Config;\n\n";
        outStr += $"public static partial class ExcelConfig\n{{\n";
        outStr += $"    public class {fileName}\n";
        outStr += $"    {{\n";
        //继承的带有引用其他表的类代码
        var outRefStr = "";
        
        var cloneFuncStr = $"        /// <summary>\n";
        cloneFuncStr += $"        /// 返回浅拷贝出的新对象\n";
        cloneFuncStr += $"        /// </summary>\n";
        cloneFuncStr += $"        public {fileName} Clone()\n";
        cloneFuncStr += $"        {{\n";
        cloneFuncStr += $"            var inst = new {fileName}();\n";
        
        var sourceFile = excelPath;
        
        //列数
        var columnCount = -1;
        
        //加载表数据
        var workbook = new Workbook(sourceFile);
        using (workbook)
        {
            var sheet1 = workbook.Worksheets[0];
            var cells = sheet1.Cells;
            //先解析表中的列名, 注释, 类型
            var names = cells.Rows[0];
            var descriptions = cells.Rows[1];
            var types = cells.Rows[2];

            columnCount = 0;
            foreach (Cell cell in names)
            {
                //字段名称
                var field = GetCellStringValue(cell);
                if (string.IsNullOrEmpty(field))
                {
                    if (cell.Column == 0)
                    {
                        throw new Exception($"表'{fileName}'的列数为0!");
                    }
                    //到达最后一列了
                    break;
                }

                columnCount++;
                field = field.FirstToUpper();
                excelData.ColumnNames.Add(field);
                if (field == "Clone")
                {
                    throw new Exception($"表'{fileName}'中不允许有'Clone'字段!");
                }

                var descriptionCell = descriptions[cell.Column];
                //描述
                string description;
                if (descriptionCell != null)
                {
                    description = GetCellStringValue(descriptionCell).Replace("\n", " <br/>\n        /// ");
                }
                else
                {
                    description = "";
                }
                //类型
                var typeString = GetCellStringValue(types[cell.Column]);
                if (string.IsNullOrEmpty(typeString))
                {
                    throw new Exception($"表'{fileName}'中'{field}'这一列类型为空!");
                }
                
                //尝试解析类型
                MappingData mappingData;
                try
                {
                    var autoParentheses = false;
                    if (typeString.EndsWith('*'))
                    {
                        autoParentheses = true;
                        typeString = typeString.TrimEnd('*');
                    }

                    mappingData = ConvertToType(typeString.Replace(" ", ""));
                    mappingData.AutoParentheses = autoParentheses;
                }
                catch (Exception e)
                {
                    PrintError(e.ToString());
                    throw new Exception($"表'{fileName}'中'{field}'这一列类型描述语法错误: {typeString}");
                }
                
                if (!excelData.ColumnMappingData.TryAdd(field, mappingData))
                {
                    throw new Exception($"表'{fileName}'中存在相同名称的列: '{field}'!");
                }
                outStr += $"        /// <summary>\n";
                outStr += $"        /// {description}\n";
                outStr += $"        /// </summary>\n";
                if (!mappingData.IsRefExcel) //没有引用其他表
                {
                    outStr += $"        [JsonInclude]\n";
                    outStr += $"        public {mappingData.TypeStr} {field};\n\n";
                }
                else
                {
                    outStr += $"        public {mappingData.RefTypeStr} {field};\n\n";
                }

                if (mappingData.IsRefExcel) //引用其他表
                {
                    if (string.IsNullOrEmpty(outRefStr))
                    {
                        outRefStr += $"    private class Ref_{fileName} : {fileName}\n";
                        outRefStr += $"    {{\n";
                    }
                    outRefStr += $"        [JsonInclude]\n";
                    outRefStr += $"        public {mappingData.TypeStr} __{field};\n\n";
                }
                
                cloneFuncStr += $"            inst.{field} = {field};\n";
            }
        
            cloneFuncStr += "            return inst;\n";
            cloneFuncStr += "        }\n";
            outStr += cloneFuncStr;
            outStr += "    }\n";

            if (!string.IsNullOrEmpty(outRefStr))
            {
                outRefStr += "    }\n";
                outStr += outRefStr;
            }
            
            outStr += "}";
            
            //解析字段类型
            foreach (var kv in excelData.ColumnMappingData)
            {
                var typeName = kv.Value.TypeName;
                var type = Type.GetType(typeName);
                if (type == null)
                {
                    throw new Exception($"表'{fileName}'中'{kv.Key}'这一列类型未知! " + kv.Value.TypeStr);
                }
                excelData.ColumnType.Add(kv.Key, type);
            }

            //解析数据
            foreach (Row row in cells.Rows)
            {
                if (row == null || row.Index < 3)
                {
                    continue;
                }
                Dictionary<string, object> data = null;
                for (int j = 0; j < columnCount; j++)
                {
                    var cell = row[j];
                    var strValue = GetCellStringValue(cell);
                    //如果这一行的第一列数据为空, 则跳过这一行
                    if (j == 0 && string.IsNullOrEmpty(strValue))
                    {
                        break;
                    }
                    else if (data == null)
                    {
                        data = new Dictionary<string, object>();
                        excelData.DataList.Add(data);
                    }

                    var fieldName = excelData.ColumnNames[j];
                    var mappingData = excelData.ColumnMappingData[fieldName];
                    var field = mappingData.IsRefExcel ? "__" + fieldName : fieldName;
                    try
                    {
                        switch (mappingData.TypeStr)
                        {
                            case "bool":
                            case "boolean":
                                data.Add(field, GetCellBooleanValue(cell));
                                break;
                            case "byte":
                                data.Add(field, Convert.ToByte(GetCellNumberValue(cell)));
                                break;
                            case "sbyte":
                                data.Add(field, Convert.ToSByte(GetCellNumberValue(cell)));
                                break;
                            case "short":
                                data.Add(field, Convert.ToInt16(GetCellNumberValue(cell)));
                                break;
                            case "ushort":
                                data.Add(field, Convert.ToUInt16(GetCellNumberValue(cell)));
                                break;
                            case "int":
                                data.Add(field, Convert.ToInt32(GetCellNumberValue(cell)));
                                break;
                            case "uint":
                                data.Add(field, Convert.ToUInt32(GetCellNumberValue(cell)));
                                break;
                            case "long":
                                data.Add(field, Convert.ToInt64(GetCellNumberValue(cell)));
                                break;
                            case "ulong":
                                data.Add(field, Convert.ToUInt64(GetCellNumberValue(cell)));
                                break;
                            case "float":
                                data.Add(field, Convert.ToSingle(GetCellNumberValue(cell)));
                                break;
                            case "double":
                                data.Add(field, GetCellNumberValue(cell));
                                break;
                            case "string":
                                data.Add(field, GetCellStringValue(cell));
                                break;
                            default:
                            {
                                var cellStringValue = GetCellStringValue(cell);
                                if (cellStringValue.Length == 0)
                                {
                                    if (mappingData.TypeStr == nameof(ActivityQuality))
                                    {
                                        ActivityQuality v = default;
                                        data.Add(field, v);
                                    }
                                    else if (mappingData.TypeStr == nameof(ActivityType))
                                    {
                                        ActivityType v = default;
                                        data.Add(field, v);
                                    }
                                    else
                                    {
                                        data.Add(field, null);
                                    }
                                }
                                else
                                {
                                    if (mappingData.AutoParentheses)
                                    {
                                        if (mappingData.CollectionsType == CollectionsType.Array)
                                        {
                                            cellStringValue = "[" + cellStringValue.TrimEnd(',') + "]";
                                        }
                                        if (mappingData.CollectionsType == CollectionsType.Map)
                                        {
                                            cellStringValue = "{" + cellStringValue.TrimEnd(',') + "}";
                                        }
                                    }
                                    data.Add(field, JsonSerializer.Deserialize(cellStringValue, excelData.ColumnType[fieldName]));
                                }
                            }
                                break;
                        }
                    }
                    catch (Exception e)
                    {
                        PrintError(e.ToString());
                        throw new Exception($"解析表'{fileName}'第'{row.Index + 1}'行第'{j + 1}'列数据时发生异常");
                    }
                }
            }
        }

        excelData.OutCode = outStr;
        return excelData;
    }

    private static string GetCellStringValue(Cell cell)
    {
        if (cell == null)
        {
            return "";
        }
        switch (cell.Type)
        {
            case CellValueType.IsNumeric:
                return cell.DoubleValue.ToString();
            case CellValueType.IsString:
                return cell.StringValue;
            case CellValueType.IsBool:
                return cell.BoolValue ? "true" : "false";
        }

        return "";
    }

    private static double GetCellNumberValue(Cell cell)
    {
        if (cell == null)
        {
            return 0;
        }
        
        switch (cell.Type)
        {
            case CellValueType.IsNumeric:
                return cell.DoubleValue;
            case CellValueType.IsString:
                return double.Parse(cell.StringValue);
            case CellValueType.IsBool:
                return cell.BoolValue ? 1 : 0;
        }
        
        return 0;
    }

    private static bool GetCellBooleanValue(Cell cell)
    {
        if (cell == null)
        {
            return false;
        }
        
        switch (cell.Type)
        {
            case CellValueType.IsNumeric:
                return cell.DoubleValue != 0;
            case CellValueType.IsString:
            {
                var value = cell.StringValue;
                if (string.IsNullOrWhiteSpace(value))
                {
                    return false;
                }
                return bool.Parse(value);
            }
            case CellValueType.IsBool:
                return cell.BoolValue;
        }

        return false;
    }

    private static MappingData ConvertToType(string str, int depth = 0)
    {
        if (Regex.IsMatch(str, "^\\w+$"))
        {
            var typeStr = TypeStrMapping(str);
            var typeName = TypeNameMapping(str);
            return new MappingData(typeStr, typeName, CollectionsType.None);
        }
        else if (Regex.IsMatch(str, "^\\$\\w+$")) //引用其他表
        {
            var realName = str.Substring(1);
            if (!_excelNames.Contains(realName))
            {
                throw new Exception($"引用表数据失败, 未找到表: {realName}!");
            }

            if (depth > 1)
            {
                throw new Exception("引用表数据失败, 引用表数据仅支持放入第一层的数组和字典!");
            }

            return new MappingData(TypeStrMapping("string"), TypeNameMapping("string"), CollectionsType.None, realName, realName);
        }
        else if (str.StartsWith('{')) //字典
        {
            var tempStr = str.Substring(1, str.Length - 2);
            var index = tempStr.IndexOf(':');
            if (index == -1)
            {
                throw new Exception("类型描述语法错误!");
            }

            var keyStr = tempStr.Substring(0, index);
            if (!IsBaseType(keyStr))
            {
                throw new Exception($"字典key类型必须是基础类型!");
            }

            var type1 = ConvertToType(keyStr, depth + 1);
            var type2 = ConvertToType(tempStr.Substring(index + 1), depth + 1);

            var typeStr = $"Dictionary<{type1.TypeStr}, {type2.TypeStr}>";
            var typeName = $"System.Collections.Generic.Dictionary`2[[{type1.TypeName}],[{type2.TypeName}]]";

            if (type2.IsRefExcel) //引用过其他表
            {
                var refTypeStr = $"Dictionary<{type1.TypeStr}, {type2.RefTypeStr}>";
                return new MappingData(typeStr, typeName, CollectionsType.Map, refTypeStr, type2.RefTypeName);
            }

            return new MappingData(typeStr, typeName, CollectionsType.Map);
        }
        else if (str.StartsWith('[')) //数组
        {
            var tempStr = str.Substring(1, str.Length - 2);
            var typeData = ConvertToType(tempStr, depth + 1);
            var typeStr = typeData.TypeStr + "[]";
            string typeName;
            var index = typeData.TypeName.IndexOf(',');
            if (index < 0)
            {
                typeName = typeData.TypeName + "[]";
            }
            else
            {
                typeName = typeData.TypeName.Substring(0, index) + "[]" + typeData.TypeName.Substring(index);
            }

            if (typeData.IsRefExcel) //引用过其他表
            {
                var refTypeStr = typeData.RefTypeStr + "[]";
                return new MappingData(typeStr, typeName, CollectionsType.Array, refTypeStr, typeData.RefTypeName);
            }
            
            return new MappingData(typeStr, typeName, CollectionsType.Array);
        }
        throw new Exception("类型描述语法错误!");
    }
    
    private static string TypeStrMapping(string typeName)
    {
        switch (typeName)
        {
            case "object": return  typeof(JsonElement).FullName;
            case "boolean": return "bool";
            case "vector2": return typeof(SerializeVector2).FullName;
            case "vector3": return typeof(SerializeVector3).FullName;
            case "color": return typeof(SerializeColor).FullName;
            case "activityType": return typeof(ActivityType).FullName;
            case "activityQuality": return typeof(ActivityQuality).FullName;
        }

        return typeName;
    }

    private static string TypeNameMapping(string typeName)
    {
        switch (typeName)
        {
            case "object":return typeof(JsonElement).AssemblyQualifiedName;
            case "bool":
            case "boolean": return typeof(bool).AssemblyQualifiedName;
            case "byte": return typeof(byte).AssemblyQualifiedName;
            case "sbyte": return typeof(sbyte).AssemblyQualifiedName;
            case "short": return typeof(short).AssemblyQualifiedName;
            case "ushort": return typeof(ushort).AssemblyQualifiedName;
            case "int": return typeof(int).AssemblyQualifiedName;
            case "uint": return typeof(uint).AssemblyQualifiedName;
            case "long": return typeof(long).AssemblyQualifiedName;
            case "ulong": return typeof(ulong).AssemblyQualifiedName;
            case "string": return typeof(string).AssemblyQualifiedName;
            case "float": return typeof(float).AssemblyQualifiedName;
            case "double": return typeof(double).AssemblyQualifiedName;
            case "vector2": return typeof(SerializeVector2).AssemblyQualifiedName;
            case "vector3": return typeof(SerializeVector3).AssemblyQualifiedName;
            case "color": return typeof(SerializeColor).AssemblyQualifiedName;
            case "activityType": return typeof(ActivityType).AssemblyQualifiedName;
            case "activityQuality": return typeof(ActivityQuality).AssemblyQualifiedName;
        }

        return typeName;
    }

    private static bool IsBaseType(string typeName)
    {
        switch (typeName)
        {
            case "bool":
            case "boolean":
            case "byte":
            case "sbyte":
            case "short":
            case "ushort":
            case "int":
            case "uint":
            case "long":
            case "ulong":
            case "string":
            case "float":
            case "double":
                return true;
        }

        return false;
    }
    
    private static void PrintError(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        Console.ResetColor();
    }
    
    /// <summary>
    /// 字符串首字母小写
    /// </summary>
    public static string FirstToLower(this string str)
    {
        return str.Substring(0, 1).ToLower() + str.Substring(1);
    }
    
    /// <summary>
    /// 字符串首字母大写
    /// </summary>
    public static string FirstToUpper(this string str)
    {
        return str.Substring(0, 1).ToUpper() + str.Substring(1);
    }
}