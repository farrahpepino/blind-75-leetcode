public class Solution {
    public bool IsPalindrome(string s) {
        List filtered = new List<char>();

        foreach (char c in s) {
            if (char.IsLetterOrDigit(c)) {
                filtered.Add(char.ToLower(c));
            }
        }
        
        string S = new string (filtered.ToArray());
        for (int i = 0, j = S.Length - 1; i < j; i++, j--) {
            if (S[i] != S[j]) {
                return false;
            }
        }
        return true;
    }
}