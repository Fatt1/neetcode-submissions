public class Solution {
    public bool IsAnagram(string s, string t) {
        char[] s1 = s.ToCharArray();
        char[] t1 = t.ToCharArray();
        Array.Sort(s1);
        Array.Sort(t1);
        return new string(s1) == new string(t1);
    }
}
