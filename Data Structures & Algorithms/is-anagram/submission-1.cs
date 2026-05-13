public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length)
        return false;
        var dic1 = new Dictionary<char, int>();
        var dic2 = new Dictionary<char, int>();
        for(int i = 0; i < s.Length; i++) {
            dic1[s[i]] = dic1.GetValueOrDefault(s[i]) + 1;
            dic2[t[i]] = dic2.GetValueOrDefault(t[i]) + 1;
        }
        foreach(var (character, seq) in dic1) {
            if(seq != dic2.GetValueOrDefault(character))
            return false;
        }
        return true;
    }
}
