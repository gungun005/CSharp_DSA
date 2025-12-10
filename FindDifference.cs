public class Solution {
    public char FindTheDifference(string s, string t) {
        char ans='\0';
        Dictionary<char,int>d=new Dictionary<char,int>();
        Dictionary<char,int>d1=new Dictionary<char,int>();
        for(int i=0;i<s.Length;i++)
        {
            if(!d.ContainsKey(s[i]))
            {
                d[s[i]]=0;
                d[s[i]]++;
            }
            else
            {
                d[s[i]]++;
            }
        }
        for(int i=0;i<t.Length;i++)
        {
            if(!d1.ContainsKey(t[i]))
            {
                d1[t[i]]=0;
                d1[t[i]]++;
            }
            else
            {
                d1[t[i]]++;
            }
        }
        //created both the dictionary now just map that whether which key exists in either of the maps!
        foreach(KeyValuePair<char,int>pair in d)
        {
                if(d1.ContainsKey(pair.Key) && d1[pair.Key]!=d[pair.Key])
                {
                    ans=pair.Key;
                }
            else if(!d1.ContainsKey(pair.Key))  
            {
                    ans=pair.Key;
            }
        }
         foreach(KeyValuePair<char,int>pair in d1)
        {
                if(d.ContainsKey(pair.Key) && d1[pair.Key]!=d[pair.Key])
                {
                    ans=pair.Key;
                }
            else if(!d.ContainsKey(pair.Key))  
            {
                    ans=pair.Key;
            }
        }
        return ans;
    }
}
