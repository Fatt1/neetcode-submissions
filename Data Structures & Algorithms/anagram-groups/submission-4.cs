public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
       var dic = new Dictionary<string, List<string>>();
foreach (var str in strs)
{
    int[] count = new int[26];
    foreach (var c in str)
    {
        count[c - 'a'] += 1;
    }
    string key = string.Join(",", count);
    if(!dic.TryGetValue(key, out var list)){
        list = new List<string>();
        dic[key] = list;
    }
    list.Add(str);

}
return dic.Values.ToList();
    }
}
