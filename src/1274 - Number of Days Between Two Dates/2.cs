// Copyright (c) 2024 Alexey Filatov
// 1274 - Number of Days Between Two Dates (https://leetcode.com/problems/number-of-days-between-two-dates)
// Date solved: 10/25/2024 9:10:08 PM +00:00
// Memory: 38.9 MB
// Runtime: 3 ms


public class Solution {
    static int[] daysInMonth = {31,28,31,30,31,30,31,31,30,31,30,31};

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
            result += IsLeapYear(i) ? 366 : 365;
        }
        for(var i = 1; i<m; i++) {
            result += daysInMonth[i-1];
            if (i==2 && IsLeapYear(y)) {
                result++;
            }
        }
        result += d-1;
        return result;
    }

    private (int, int, int) ParseDate(string date)
    {
        var parts = date.Split('-');
        return (int.Parse(parts[0]), int.Parse(parts[1]), int.Parse(parts[2]));
    }

    private bool IsLeapYear(int year)
        => (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
}
