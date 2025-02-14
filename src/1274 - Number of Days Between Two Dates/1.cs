// Copyright (c) 2024 Alexey Filatov
// 1274 - Number of Days Between Two Dates (https://leetcode.com/problems/number-of-days-between-two-dates)
// Date solved: 10/25/2024 8:32:33 PM +00:00
// Memory: 38.3 MB
// Runtime: 3 ms


public class Solution {
    public int DaysBetweenDates(string date1, string date2) {
        if (string.Compare(date1, date2)>0) {
            return DaysBetweenDates(date2, date1);
        }
        var (y1, m1, d1) = ParseDate(date1);
        var (y2, m2, d2) = ParseDate(date2);
        var r1 = GetDaysFromYear(y1, y1, m1, d1);
        var r2 = GetDaysFromYear(y1, y2, m2, d2);
        return r2-r1;
    }

    private int GetDaysFromYear(int startYear, int y, int m, int d)
    {
        var result = 0;
        for(var i = startYear; i<y; i++) {
            result += GetDaysInYear(i);
        }
        for(var i = 1; i<m; i++) {
            result += GetDaysInMonth(y, i);
        }
        result += d-1;
        return result;
    }

    private (int, int, int) ParseDate(string date)
    {
        var parts = date.Split('-');
        return (int.Parse(parts[0]), int.Parse(parts[1]), int.Parse(parts[2]));
    }

    private int GetDaysInYear(int year)
        => IsLeapYear(year) ? 366 : 365;

    private bool IsLeapYear(int year)
        => (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    
    private int GetDaysInMonth(int year, int month)
        => month switch {
            1 => 31,
            2 => IsLeapYear(year) ? 29 : 28,
            3 => 31,
            4 => 30,
            5 => 31,
            6 => 30,
            7 => 31,
            8 => 31,
            9 => 30,
            10 => 31,
            11 => 30,
            12 => 31
        };
}
