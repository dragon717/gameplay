using System;
using System.Collections.Generic;
using Godot;

/// <summary>
/// 随机数类
/// </summary>
public class SeedRandom
{
    /// <summary>
    /// 种子值
    /// </summary>
    public int Seed { get; }

    private Random _random;
    private static int _staticSeed = 0;

    public SeedRandom(int seed)
    {
        Seed = seed;
        _random = new Random(seed);
    }

    public SeedRandom()
    {
        var dateTime = DateTime.Now;
        var num = dateTime.Year * 100000 + dateTime.Month * 100000 + dateTime.Day * 100000 + dateTime.Hour * 10000 +
                  dateTime.Minute * 100 + dateTime.Second;
        num += _staticSeed;
        _staticSeed += 11111;
        Seed = num;
        _random = new Random(num);
    }

    /// <summary>
    /// 返回一个随机的double值
    /// </summary>
    public double RandomDouble()
    {
        return _random.NextDouble();
    }

    /// <summary>
    /// 返回随机 boolean 值
    /// </summary>
    public bool RandomBoolean()
    {
        return _random.NextSingle() >= 0.5f;
    }

    /// <summary>
    /// 指定概率会返回 true, probability 范围 0 - 1
    /// </summary>
    public bool RandomBoolean(float probability)
    {
        return _random.NextSingle() <= probability;
    }

    /// <summary>
    /// 返回一个区间内的随机小数
    /// </summary>
    public float RandomRangeFloat(float min, float max)
    {
        if (min == max) return min;
        if (min > max)
            return _random.NextSingle() * (min - max) + max;
        return _random.NextSingle() * (max - min) + min;
    }

    /// <summary>
    /// 返回一个区间内的随机整数
    /// </summary>
    public int RandomRangeInt(int min, int max)
    {
        if (min == max) return min;
        if (min > max)
            return Mathf.FloorToInt(_random.NextSingle() * (min - max + 1) + max);
        return Mathf.FloorToInt(_random.NextSingle() * (max - min + 1) + min);
    }

    /// <summary>
    /// 根据配置表中配置的范围数据, 随机返回范围内的一个值
    /// </summary>
    public int RandomConfigRange(int[] range)
    {
        return RandomRangeInt(Utils.GetConfigRangeStart(range), Utils.GetConfigRangeEnd(range));
    }

    /// <summary>
    /// 根据配置表中配置的范围数据, 随机返回范围内的一个值
    /// </summary>
    public float RandomConfigRange(float[] range)
    {
        return RandomRangeFloat(Utils.GetConfigRangeStart(range), Utils.GetConfigRangeEnd(range));
    }

    /// <summary>
    /// 随机返回其中一个参数
    /// </summary>
    public T RandomChoose<T>(params T[] list)
    {
        if (list.Length == 0)
        {
            return default;
        }

        return list[RandomRangeInt(0, list.Length - 1)];
    }

    /// <summary>
    /// 随机返回集合中的一个元素
    /// </summary>
    public T RandomChoose<T>(List<T> list)
    {
        if (list.Count == 0)
        {
            return default;
        }

        return list[RandomRangeInt(0, list.Count - 1)];
    }

    /// <summary>
    /// 随机返回集合中的一个元素, 并将其从集合中移除
    /// </summary>
    public T RandomChooseAndRemove<T>(List<T> list)
    {
        if (list.Count == 0)
        {
            return default;
        }

        var index = RandomRangeInt(0, list.Count - 1);
        var result = list[index];
        list.RemoveAt(index);
        return result;
    }

    /// <summary>
    /// 从权重列表中随机抽取下标值
    /// </summary>
    public int RandomWeight(List<int> weightList)
    {
        // 计算总权重
        var totalWeight = 0;
        foreach (var weight in weightList)
        {
            totalWeight += weight;
        }

        var randomNumber = _random.Next(totalWeight);
        var currentWeight = 0;
        for (var i = 0; i < weightList.Count; i++)
        {
            var value = weightList[i];
            currentWeight += value;
            if (randomNumber < currentWeight)
            {
                return i;
            }
        }

        return RandomRangeInt(0, weightList.Count - 1);
    }

    /// <summary>
    /// 从权重列表中随机抽取下标值
    /// </summary>
    public int RandomWeight(int[] weightList)
    {
        // 计算总权重
        var totalWeight = 0;
        foreach (var weight in weightList)
        {
            totalWeight += weight;
        }

        var randomNumber = _random.Next(totalWeight);
        var currentWeight = 0;
        for (var i = 0; i < weightList.Length; i++)
        {
            var value = weightList[i];
            currentWeight += value;
            if (randomNumber < currentWeight)
            {
                return i;
            }
        }

        return RandomRangeInt(0, weightList.Length - 1);
    }

    /// <summary>
    /// 返回指定区域内的随机坐标点, 该函数比较慢, 请谨慎调用
    /// </summary>
    public Vector2[] GetRandomPositionInPolygon(List<Vector2> vertices, List<int[]> polygons, int count)
    {
        if (vertices.Count == 0 || polygons.Count == 0)
        {
            return Vector2.Zero.MakeArray(count);
        }

        var minX = int.MaxValue;
        var maxX = int.MinValue;
        var minY = int.MaxValue;
        var maxY = int.MinValue;

        // 遍历多边形的顶点，找到最小和最大的x、y坐标
        foreach (var vertex in vertices)
        {
            if (vertex.X < minX)
            {
                minX = Mathf.CeilToInt(vertex.X);
            }
            else if (vertex.X > maxX)
            {
                maxX = Mathf.FloorToInt(vertex.X);
            }

            if (vertex.Y < minY)
            {
                minY = Mathf.CeilToInt(vertex.Y);
            }
            else if (vertex.Y > maxY)
            {
                maxY = Mathf.FloorToInt(vertex.Y);
            }
        }

        var list = new List<Vector2>();
        var tryCount = 0;
        while (true)
        {
            if (tryCount >= 2000) //尝试2000次后放弃
            {
                while (list.Count < count)
                {
                    list.Add(Vector2.Zero);
                }

                break;
            }

            tryCount++;
            var point = new Vector2(RandomRangeInt(minX, maxX), RandomRangeInt(minY, maxY));
            foreach (var ps in polygons)
            {
                var arr = new List<Vector2>();
                foreach (var i in ps)
                {
                    arr.Add(vertices[i]);
                }

                if (Utils.IsPointInPolygon(arr, point))
                {
                    tryCount = 0;
                    list.Add(point);
                    if (list.Count >= count)
                    {
                        return list.ToArray();
                    }
                }
            }
        }

        return list.ToArray();
    }

    /// <summary>
    /// 返回指定多边形区域内的随机坐标点
    /// 注意：每个多边形应由三角形组成（三个顶点索引）
    /// </summary>
    public Vector2[] GetRandomPositionInPolygon2(List<Vector2> vertices, List<int[]> polygons, int count)
    {
        List<int[]> validPolygons = new List<int[]>();
        List<float> areas = new List<float>();
        float totalArea = 0f;

        // 过滤有效三角形并计算面积
        foreach (int[] poly in polygons)
        {
            if (poly.Length < 3)
                continue;

            Vector2 a = vertices[poly[0]];
            Vector2 b = vertices[poly[1]];
            Vector2 c = vertices[poly[2]];

            float area = Mathf.Abs((b.X - a.X) * (c.Y - a.Y) - (b.Y - a.Y) * (c.X - a.X)) * 0.5f;
            validPolygons.Add(poly);
            areas.Add(area);
            totalArea += area;
        }

        if (totalArea <= Mathf.Epsilon || count == 0 || validPolygons.Count == 0)
            return new Vector2[0];

        // 构建累积面积数组
        List<float> cumulativeAreas = new List<float>(areas.Count);
        float currentSum = 0;
        foreach (float area in areas)
        {
            currentSum += area;
            cumulativeAreas.Add(currentSum);
        }

        // 生成随机点
        Vector2[] points = new Vector2[count];
        for (int i = 0; i < count; i++)
        {
            // 选择随机三角形（使用当前实例的随机生成器）
            float randomValue = (float)_random.NextDouble() * totalArea;
            int triangleIndex = cumulativeAreas.BinarySearch(randomValue);
            if (triangleIndex < 0) triangleIndex = ~triangleIndex;
            if (triangleIndex >= validPolygons.Count) triangleIndex = validPolygons.Count - 1;

            // 获取三角形顶点
            int[] poly = validPolygons[triangleIndex];
            Vector2 a = vertices[poly[0]];
            Vector2 b = vertices[poly[1]];
            Vector2 c = vertices[poly[2]];

            // 生成均匀分布的随机点（使用当前实例的随机生成器）
            float u = (float)_random.NextDouble();
            float v = (float)_random.NextDouble();

            if (u + v > 1)
            {
                u = 1 - u;
                v = 1 - v;
            }

            points[i] = new Vector2(
                a.X * (1 - u - v) + b.X * u + c.X * v,
                a.Y * (1 - u - v) + b.Y * u + c.Y * v
            );
        }

        return points;
    }

    /// <summary>
    /// 生成一个表示圆形视野范围的多边形。
    /// </summary>
    /// <param name="center">视野的中心点。</param>
    /// <param name="viewDistance">视野的距离半径。</param>
    /// <param name="segments">构成圆形的线段数量，值越大，圆形越平滑。</param>
    /// <returns>包含多边形顶点和三角形索引的元组。</returns>
    public (List<Vector2> vertices, List<int[]> polygons) GenerateCircularVisibilityPolygon(Vector2 center,
        uint viewDistance, int segments = 64)
    {
        if (segments < 3)
        {
            throw new ArgumentException("线段数量必须大于等于 3。", nameof(segments));
        }

        List<Vector2> vertices = new List<Vector2>();
        List<int[]> polygons = new List<int[]>();

        // 添加中心点作为第一个顶点
        vertices.Add(center);

        // 计算圆形上的顶点
        for (int i = 0; i <= segments; i++)
        {
            float angle = 2f * Mathf.Pi * i / segments;
            float x = center.X + viewDistance * Mathf.Cos(angle);
            float y = center.Y + viewDistance * Mathf.Sin(angle);
            vertices.Add(new Vector2(x, y));
        }

        // 生成三角形索引
        for (int i = 1; i <= segments; i++)
        {
            polygons.Add(new int[] { 0, i, i + 1 });
        }

        return (vertices, polygons);
    }
}