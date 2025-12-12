public class Solution {
    public void MoveZeroes(int[] nums) {
    int i=0;
    int j=1;
    while(j<nums.Length)
    {
        if(nums[i]==0 && nums[j]==0)
        {
            j++;
        }
        else if(nums[i]==0 && nums[j]!=0)
        {
            (nums[i],nums[j])=(nums[j],nums[i]);
            i++;
            j++;
        }
        else
        {
            i++;j++;
        }
    }
    }
}
