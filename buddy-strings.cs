// Buddy Strings
// https://leetcode.com/problems/buddy-strings
// Date solved: 10/12/2020 17:04:52 +00:00

// if 0 chars diff - do we have 2 similar chars?
// if 2 chars diff - are they in the opposite positions?
// otherwise false
public class Solution {
    public bool BuddyStrings(string A, string B) {
        if (A.Length!=B.Length) {
            return false;
        }
        int index1 = -1;
        int index2 = -1;
        var count = 0;
        for(var i = 0; i<A.Length; i++) {
            if (A[i]!=B[i]) {
                if (count==2) {
                    return false;
                }
                if (index1==-1) {
                    index1 = i;
                }
                else {
                    index2 = i;
                }
                count++;
            }
        }
        if (count==2) {
            return A[index1] == B[index2] && A[index2] == B[index1];
        }
        else if (count==0) {
            var chars = new HashSet<char>();
            foreach(var c in A) {
                if (chars.Contains(c)) {
                    return true;
                }
                chars.Add(c);
            }
            return false;
        }
        else {
            return false;
        }
    }
}
