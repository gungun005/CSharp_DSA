public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        //implementing a map in c#
        //In c# we will create dictionary that is equivalent of making a map in c++
        Dictionary<int,int>map=new Dictionary<int,int>();
        //In c# we take Count method to find the size of array 
        //Readline()->doesnot take any parameters
        for(int i=0;i<nums.Length;i++)
        {
            map[nums[i]]=i;
        }
        for (int i=0;i<nums.Length;i++)
        {
            if(map.ContainsKey(target-nums[i]) && map[target-nums[i]]!=i)
            {
                return[i,map[target-nums[i]]];
            }
        }
        return [];
    }
};
