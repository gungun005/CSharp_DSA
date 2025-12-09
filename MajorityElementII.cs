public class Solution {
    public IList<int> MajorityElement(int[] nums) {
        Dictionary<int,int>d=new Dictionary<int,int>();
        IList<int> values = new List<int>();
        for(int i=0;i<nums.Length;i++)
        {
            if(!d.ContainsKey(nums[i]))
            {
                d[nums[i]]=0;
                d[nums[i]]++;
            }
            else
            {
                d[nums[i]]++;
            }
        }
        foreach(KeyValuePair<int,int>pair in d) 
        {
            if(pair.Value>(nums.Length/3))
            {
                values.Add(pair.Key);
            }
        }
        return values;
    }
}
