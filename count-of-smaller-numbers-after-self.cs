// Count of Smaller Numbers After Self
// https://leetcode.com/problems/count-of-smaller-numbers-after-self
// Date solved: 04/18/2020 06:51:44 +00:00

    public class Solution
    {
        private int[] nums;
        private int[] ans;

        public IList<int> CountSmaller(int[] nums)
        {
            this.nums = nums;
            ans = new int[nums.Length];
            var idx = Enumerable.Range(0, nums.Length).ToArray();
            MergeSort(idx, 0, idx.Length - 1);
            return ans;
        }

        private int[] MergeSort(int[] arr, int start, int end)
        {
            if (end < start) return Array.Empty<int>();
            if (end == start) return new[] { arr[start] };

            var med = start + (end - start) / 2;
            
            var leftArr = MergeSort(arr, start, med);
            var rightArr = MergeSort(arr, med + 1, end);
            
            var result = new List<int>(leftArr.Length + rightArr.Length);
            for (int lp = 0, rp = 0; lp < leftArr.Length || rp < rightArr.Length;) {
                if (rp == rightArr.Length || (lp < leftArr.Length && nums[leftArr[lp]] <= nums[rightArr[rp]])) {
                    result.Add(leftArr[lp]);
                    ans[leftArr[lp]] += rp;
                    lp++;
                }
                else {
                    result.Add(rightArr[rp]);
                    rp++;
                }
            }
            
            return result.ToArray();
        }
    }

