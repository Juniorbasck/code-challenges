public class Program
{
    public static void Main(string[] args)
    {
        string s  = "A man, a plan, a canal: Panama";
        
        var result = IsPalindrome(s);
        
        Console.WriteLine("Is a Palindrome: " + result);
    }
    
    public static bool IsPalindrome(string s)
    {
        var pharase = s.ToLower().ToArray();

        int left = 0;
        int right = pharase.Length - 1;

        while(left < right){
            
            while(left < right && !char.IsLetterOrDigit(pharase[left])){
                left++;
            }
            
            
            while(left < right && !char.IsLetterOrDigit(pharase[right])){
                right--;
            }
            
            bool isDiferent = pharase[left] == pharase[right];

            if(!isDiferent){    
                return false;
            }

            left = latterLeft + 1;
       
            right = latteright - 1;
        }

        return true;
    }
}