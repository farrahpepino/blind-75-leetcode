public class Solution {
    public bool ContainsDuplicate(int[] nums) {
       HashSet<int> seen = new HashSet<int>();
       foreach(int n in nums){
            if (seen.Contains(n)){
                return true;
            }
            seen.Add(n);
       }
       return false;
    }
}

