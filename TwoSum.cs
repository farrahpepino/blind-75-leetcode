public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        List<int> sum = new List<int>();
        for(int i=0; i<nums.Length; i++){
            for(int j=i+1; j<nums.Length; j++){
                if(nums[i]+nums[j]==target){
                    sum.Add(i);
                    sum.Add(j);
                }
            }
            
        }
        int[] arr= sum.ToArray();
        return arr;
    }
}