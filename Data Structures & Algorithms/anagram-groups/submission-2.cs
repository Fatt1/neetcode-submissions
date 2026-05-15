public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var dic = new Dictionary<string,List<string>>();
        foreach(var str in strs){
           int[] count = new int [26];
           foreach(var c in str){
                count[c - 'a'] += 1;
           }
           string key = string.Join(",", count);
           List<string> find = dic.GetValueOrDefault(key, new List<string>());
           if(find.Count == 0)
            dic.Add(key, find);
           find.Add(str);
           
        }
        return dic.Values.ToList();
    }
}
