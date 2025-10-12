public class Solution
{
    public string LongestPalindrome(string s)
    {

        if (string.IsNullOrEmpty(s)) return s;

        int n = s.Length;

        var bestStart = 0;
        var bestLen = 1;


        for (int i = 0; i < n; i++)
        {

            // centro ímpar (i, i)
            var (start1, len1) = Expand(s, i, i);

            if (len1 > bestLen)
            {
                bestStart = start1;
                bestLen = len1;
            }

            // centro par (i, i+1)
            var (start2, len2) = Expand(s, i, i + 1);

            if (len2 > bestLen)
            {
                bestStart = start2;
                bestLen = len2;
            }

        }

        public function Expand(string s, int l, int r)
    {
        int n = s.Length;
        while (l >= 0 && r < n && s[l] == s[r])
        {
            l--;
            r++;
        }
        int start = l + 1;
        int len = r - l - 1;
        return (start, len);
    }

        return s.Substring(bestStart, bestLen)
}
}