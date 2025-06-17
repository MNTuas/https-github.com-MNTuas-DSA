public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> map = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++){
            int remain = target - nums[i];

            if(map.ContainsKey(remain)){
                return new int[] {map[remain], i};
            }

            map[nums[i]] = i;
        }
        return new int[0];
    }
}