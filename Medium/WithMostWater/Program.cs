public class Program
{
    public static void Main(string[] args)
    {

        int[] height = new[] { 1, 8, 6, 2, 5, 4, 8, 3, 7};

        var result = WithMostWater(height);
        
        Console.WriteLine("The result is: " + result);
    }

    public static int WithMostWater(int[] height)
    {
        int left = 0;
        int right = height.Length - 1;
        int maxArea = 0;

        while (left < right)
        {
            int width = right - left;
            int currentHeight = Math.Min(height[right], height[left]);
            var currentArea = width * currentHeight;

            if (currentArea > maxArea)
            {
                maxArea = currentArea;
            }

            if (height[left] < height[right])
            {
                left++;   
            }
            else
            {
                right--;
            }

        }
        
        return maxArea;
    }
}