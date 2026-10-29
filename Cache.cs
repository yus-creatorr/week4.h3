static class Cache<T>
{
    private static Dictionary<string, T> data = new Dictionary<string, T>();

    public static void Add(string key, T value)
    {
        data[key] = value;
    }

    public static T Get(string key)
    {
        return data[key];
    }

    public static void Remove(string key)
    {
        data.Remove(key);
    }
}