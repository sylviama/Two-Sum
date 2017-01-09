public class Solution {
    List<int> listResult=new List<int>();
    public int[] TwoSum(int[] nums, int target) {
        
        for(var i=0; i<nums.Length;i++)
        {
            for(var j=i+1;j<nums.Length;j++)
            {
                if(nums[j]==target-nums[i])
                {
                    listResult.Add(i);
                    listResult.Add(j);
                    return listResult.ToArray();
                }
            }
        }
        return listResult.ToArray();
    }
}
