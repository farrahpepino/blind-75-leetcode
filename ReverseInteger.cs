public class Solution {
    public int Reverse(int x) {
        string s = x.ToString();
        List<char> digits = new List<char>();

        foreach (char c in s) {
            if (char.IsDigit(c)) {
                digits.Add(c);
            }
        }

        digits.Reverse();

        string reversedDigits = new string(digits.ToArray());

        if (s[0] == '-') {
            reversedDigits = "-" + reversedDigits;
        }

        if (int.TryParse(reversedDigits, out int result)) {
            return result;
        }

        return 0; 
    }
}
