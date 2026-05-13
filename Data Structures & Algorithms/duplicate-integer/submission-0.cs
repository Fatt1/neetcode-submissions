public class Solution {
    public bool hasDuplicate(int[] nums) {
        var hashMap = new Dictionary<int,int>();
        foreach(var num in nums){
            if(hashMap.ContainsKey(num))
            return true;
            hashMap.Add(num, num);

        }
        return false;
    }
}