// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
//
//     You may assume that each input would have exactly one solution, and you may not use the same element twice.
//
//     You can return the answer in any order.

// nums = [2,7,11,15] target = 9
// indices 0 1 2  3      
// return [o, 1]

//  para n menor que nums
//  completo = targe - nums[i]
//  está no dicirario o completo que preciso?
//       retora o completo com indice achado com o indicie atual tbm
// coloca no dicioarnio o valor atual e indice

public class Suletion
{
    public static void Main()
    {
        
        int[] nums =new[] {2,7,11,15};
        int targe = 9;
        var result = FindIndicestarge(nums, targe);
        Console.WriteLine($"Expeted [0, 1 ] but actual = {result[0]} + {result[1]}" );
    }

    public static int[] FindIndicestarge(int[] nums, int targe)
    {
        Dictionary<int, int> complementsMap = new Dictionary<int, int>();

        for (int counter = 0; counter < nums.Length; counter++)
        {
            var complement = targe - nums[counter];

            Console.WriteLine("DEBUG - complment is: " + complement);
            
            if (complementsMap.TryGetValue(complement, out int indice))
            {
                return [counter, indice];
            }
            
            complementsMap[nums[counter]] = counter;
        }
        
        throw new ArgumentException("No sulution found");
    }
}

// Complexidade O(N) 