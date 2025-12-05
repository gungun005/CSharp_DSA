public class Solution {
    public int MajorityElement(int[] nums) {
        int ans=0;
        Dictionary<int,int>map=new Dictionary<int,int>();
        for(int i=0;i<nums.Length;i++)
        {
            if(!map.ContainsKey(nums[i]))
            {
                map[nums[i]]=0;
                map[nums[i]]++;
            }
            else
            {
                map[nums[i]]++;
            }
        }
        int comp=nums.Length/2;
        foreach(KeyValuePair<int,int>m in map)
        {
            //traversing both key and value in dictionary which works as map in c#
            if(m.Value>comp)
            {
                ans=m.Key;
            }
        }
        return ans;
    }
}
