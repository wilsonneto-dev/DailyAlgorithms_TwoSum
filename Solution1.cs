public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> dictionary = new Dictionary<int, int>();
        for(int i = 0; i < nums.Count(); i++)
        {
            var neededNumber = target - nums[i];
            if(dictionary.ContainsKey(neededNumber))
                return new int[] { dictionary[neededNumber], i };
            if(!dictionary.ContainsKey(nums[i]))
                dictionary.Add(nums[i], i);
        }
        return null;
    }
}
