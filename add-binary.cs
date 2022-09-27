// Add Binary
// https://leetcode.com/problems/add-binary
// Date solved: 07/19/2020 10:39:46 +00:00

public class Solution {
    public string AddBinary(string a, string b) {        
        var i = 0;
        var result = new List<char>();
        var over = false;
        while(i<a.Length || i<b.Length) {
            var x = i<a.Length ? a[a.Length-1-i]=='1' : false;
            var y = i<b.Length ? b[b.Length-1-i]=='1' : false;
            result.Add((x^y^over) ? '1' : '0');
            over = x && y || x&&over || y&&over;
            i++;
        }
        if (over) {
            result.Add('1');
        }
        result.Reverse();
        return new string(result.ToArray());
    }
}
