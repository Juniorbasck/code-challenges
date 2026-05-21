public class Solution {
    public static void Main()
    {

        string firstWord = "anagram";
        string secondWord = "nagaram";
        var result = IsAnagram(firstWord,secondWord);
        Console.WriteLine(result);
    }

    public static bool IsAnagram(string s, string t)
    {
        var firstWord = s.ToArray();
        var secondWord = t.ToArray();
        
        // if (sizeFirst != sizeSecond) return false;

        var letterConters = new Dictionary<char, int>();

        foreach (char latter in firstWord)
        {
            if (!letterConters.ContainsKey(latter))
                letterConters.Add(latter, 1);
    
            letterConters[latter]++;        
        }

        foreach (char latter in secondWord)
        {
            if (!letterConters.ContainsKey(latter))
            {
                return false;
            }
            
            letterConters[latter]--;
        }


        return true;
    }
}