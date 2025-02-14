// Copyright (c) 2024 Alexey Filatov
// 1584 - Average Salary Excluding the Minimum and Maximum Salary (https://leetcode.com/problems/average-salary-excluding-the-minimum-and-maximum-salary)
// Date solved: 12/18/2024 2:57:43 AM +00:00
// Memory: 40.5 MB
// Runtime: 0 ms


public class Solution {
    public double Average(int[] salary) {
        var min = salary[0];
        var max = 0;
        var sum = 0;
        foreach(var s in salary) {
            min = Math.Min(min, s);
            max = Math.Max(max, s);
            sum += s;
        }
        return (sum-max-min) / ((double)salary.Length - 2);
    }
}
