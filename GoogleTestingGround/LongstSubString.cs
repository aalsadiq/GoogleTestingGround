public class Solution {
    public int LengthOfLongestSubstring(string s) {
        
        var arr = s.ToCharArray();
        HashSet<char> set= new HashSet<char>();
        int finalCount = 0;
        int count = 0;
        
        foreach(char c in arr){
            if( !set.Contains(c) )
            {
                set.Add(c);
                count++;         
            }
            else
            {
               finalCount = Math.Max(finalCount,count);
               set.Clear();
               set.Add(c);
               count = 1;
            }
            finalCount = Math.Max(finalCount,count);
        }
        
        return finalCount;
    }
}
