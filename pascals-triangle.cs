// Pascal's Triangle
// https://leetcode.com/problems/pascals-triangle
// Date solved: 03/18/2020 05:55:01 +00:00

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
