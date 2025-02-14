// Copyright (c) 2024 Alexey Filatov
// 12 - Integer to Roman (https://leetcode.com/problems/integer-to-roman)
// Date solved: 8/26/2024 12:51:20 AM +00:00
// Memory: 44.8 MB
// Runtime: 54 ms


public class Solution {
    public string IntToRoman(int num) {
        var sb = new StringBuilder();
        while(num>0) {
            sb.Append(X(ref num));
        }
        return sb.ToString();
    }

    private string X(ref int num)
    {
        if (num==4) {
            num -= 4;
            return "IV";
        }
        else if (num==9) {
            num -= 9;
            return "IX";
        }
        else if (num/10==4) {
            num -= 40;
            return "XL";
        }
        else if (num/10==9) {
            num -= 90;
            return "XC";
        }
        else if (num/100==4) {
            num -= 400;
            return "CD";
        }
        else if (num/100==9) {
            num -= 900;
            return "CM";
        }
        else if (num >= 1000) {
            num -= 1000;
            return "M";
        }
        else if (num >= 500) {
            num -= 500;
            return "D";
        }
        else if (num >= 100) {
            num -= 100;
            return "C";
        }
        else if (num >= 50) {
            num -= 50;
            return "L";
        }
        else if (num >= 10) {
            num -= 10;
            return "X";
        }
        else if (num >= 5) {
            num -= 5;
            return "V";
        }
        else if (num >= 1) {
            num -= 1;
            return "I";
        }
        else {
            throw new Exception("ex");
        }  
    }
}
