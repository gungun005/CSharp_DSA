/* How to declare a list in C#
List<int>l=new List<int>();
#How to get the max/min value like INT_MAX OR INT_MIN IN C++=>int.Min /int.Max
*/

public class Solution {
    public List<int> getMinMax(int[] arr) {
        // code here
        List<int>ans=new List<int>();
        int mini=int.MaxValue;
        int maxi=int.MinValue;
        for(int i=0;i<arr.Length;i++)
        {
            mini=Math.Min(mini,arr[i]);
            maxi=Math.Max(maxi,arr[i]);
            
        }
        ans.Add(mini);
        ans.Add(maxi);
        return ans;
    }
}
