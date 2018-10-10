// This is the solutionto the TwoSums problem on CodeLeet

public class Solution {

    public int[] TwoSum(int[] nums, int target) {
        
        // Creating a Dictionary to hold Values and their Indecies
        Dictionary<int,int> numsDic = new Dictionary<int, int>();
        
        // For Loop to go through the Array
        for(int i=0; i< nums.Length; i++)
        {
        
            // Checking if the Combliment for the CurrentValue already exists in the Dictionary
            if(numsDic.TryGetValue(target - nums[i],out int index)){
                return new[] {i , index};
            }
            
            // Checking if the value was already added to the Dictionary ... (some other versions of the problem states that the values are unique)
            else if(!numsDic.ContainsKey(nums[i]))
            {
                numsDic.Add(nums[i],i);
            }
        }
        
        return null;
    }
}
