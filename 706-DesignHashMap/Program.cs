public class MyHashMap
{
    private Dictionary<int, int> _hashMap;
    public MyHashMap()
    {
        _hashMap = new Dictionary<int, int>();
    }

    public void Put(int key, int value)
    {
        if(_hashMap.ContainsKey(key))
            _hashMap[key] = value;
        else
            _hashMap.Add(key, value);
    }

    public int Get(int key)
    {
        if (_hashMap.ContainsKey(key))
            return _hashMap[key];
        else
            return -1;
    }

    public void Remove(int key)
    {
        _hashMap.Remove(key);
    }
}