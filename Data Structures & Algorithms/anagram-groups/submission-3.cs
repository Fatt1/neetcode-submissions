public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var dic = new Dictionary<string,List<string>>();
        foreach(var str in strs){
          // O(m * nlog(n))
          char[] character = str.ToCharArray();
          Array.Sort(character);
          string sortedString = new String(character);
          if(!dic.TryGetValue(sortedString, out var list)){
            list = new List<string>();
            dic[sortedString] = list;
          }
          list.Add(str);
           
        }
        return dic.Values.ToList();
    }
}
