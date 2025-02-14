// Copyright (c) 2024 Alexey Filatov
// 273 - Integer to English Words (https://leetcode.com/problems/integer-to-english-words)
// Date solved: 10/30/2024 9:28:15 PM +00:00
// Memory: 40.1 MB
// Runtime: 1 ms


public class Solution {
    Dictionary<int, string> vals = new() {
        { 1000000000, "Billion" },
        { 1000000, "Million" },
        { 1000, "Thousand" },
        { 100, "Hundred" }
    };

    string[] tenNames = new[] {"", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"};

    string[] first19 = new[] {
        "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };

    public string NumberToWords(int num) {
        if (num==0) {
            return "Zero";
        }

        var result = "";

        foreach(var (val, word) in vals) {
            var n = num / val;
            if (n!=0) {
                result += " " + NumberToWords(n) + " " + word;
            }
            num -= val * n;
        }

        if (num>=20) {
            var tens = num / 10;
            //Console.WriteLine(tens);
            if (tens>1) {
                result += " " + tenNames[tens];
            }
            num -= tens * 10;
        }

        if (num>0 && num<=19) {
            result += " " + first19[num-1];
        }

        return result.Trim();
    }
}
