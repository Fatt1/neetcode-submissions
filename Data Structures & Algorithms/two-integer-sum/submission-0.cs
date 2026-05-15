public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var dic = new Dictionary<int,int>();
        for(int i = 0; i < nums.Length; i++){
            if(dic.ContainsKey(nums[i])) {
                return new int [2] {dic[nums[i]], i};
            }
            dic.Add(target - nums[i], i);
        }
        return new int [2];
    }
}
