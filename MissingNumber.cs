public class Solution {
    public int MissingNumber(int[] nums) {
        for (int i=0;i<nums.Length; i++){
            bool exists=false;
            for (int j = 0; j<nums.Length; j++){
                if(i==nums[j]){
                    exists=true;
                }
            }
            if (!exists){
                return i;
            }
        }
        return nums.Length;
    }
}