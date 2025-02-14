// Copyright (c) 2020 Alexey Filatov
// 118 - Pascal's Triangle (https://leetcode.com/problems/pascals-triangle)
// Date solved: 3/18/2020 5:55:01 AM +00:00
// Memory: 25.6 MB
// Runtime: 216 ms


public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        var result = new List<IList<int>>();
        if (numRows==0) return result;
        var row = new List<int>();
        row.Add(1);
        result.Add(row);
        for(var i = 1;i<numRows;i++) {
            var newRow = new List<int>();
            newRow.Add(1);
            for(var j=0;j<row.Count-1;j++) {
                newRow.Add(row[j]+row[j+1]);
            }
            newRow.Add(1);
            result.Add(newRow);
            row = newRow;
        }
        return result;
    }
}
