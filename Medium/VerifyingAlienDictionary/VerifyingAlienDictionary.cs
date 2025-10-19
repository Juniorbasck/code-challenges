public class Solution
{
    public bool IsAlienSorted(string[] words, string order)
    {

        int[] oderMap = new int[26];

        for (int i = 0; i < order.Length; i++)
        {
            oderMap[order[i] - 'a'] = i;
        }

        for (int i = 0; i < words.Length - 1; i++)
        {
            string word1 = words[i];
            string word2 = words[i + 1];

            int minLenght = Math.Min(word1.Length, word2.Length);

            bool difference = false;

            for (int j = 0; j < minLenght; j++)
            {
                char char1 = word1[j];
                char char2 = word2[j];

                if (char1 != char2)
                {
                    int rank1 = oderMap[char1 - 'a'];
                    int rank2 = oderMap[char2 - 'a'];

                    if (rank1 > rank2)
                    {
                        return false;
                    }

                    difference = true;
                    break;
                }
            }

            if (!difference && word1.Length > word2.Length)
            {
                return false;
            }
        }

        return true;
    }
}