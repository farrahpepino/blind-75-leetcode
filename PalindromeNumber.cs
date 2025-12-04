public class Solution {
    public bool IsPalindrome(int x) {
        string s = x.ToString();
        char[] arr = s.ToCharArray();
        for(int i=0, j=arr.Length-1; i<j; i++, j--){
            if(arr[i]!=arr[j]){
                return false;
            }
        }
        return true;
    }
}