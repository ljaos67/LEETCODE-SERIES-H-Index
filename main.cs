public class Solution {
    public int HIndex(int[] citations) 
    {
        int n = citations.Length;
        int cnt = 0;
        while(n >= 1)
        {
            for(int i = 0; i < citations.Length; i++)
            {
                if(citations[i] >= n)
                {
                    cnt++;
                }
            }
            if(cnt >= n)
                return n;
            cnt = 0;
            n--;
        }
        return 0;
    }
}
