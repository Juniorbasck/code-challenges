public int[] TwoSum(int[] nums, int target) {

        var map = new Dictionary<int, int>(); // valor -> índice


        for(int i = 0; i < nums.Length; i++){

            int complement = target - nums[i];
            if (map.TryGetValue(complement, out int j))
            {
                return new int[] { j, i }; // achou os dois índices
            }

           map[nums[i]] = i;
        }
        
        throw new ArgumentException("No solution found");
}