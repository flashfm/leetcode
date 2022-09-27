// Prison Cells After N Days
// https://leetcode.com/problems/prison-cells-after-n-days
// Date solved: 07/19/2020 23:09:54 +00:00

using System;
using System.Collections.Generic;

public class Solution {
    public int[] PrisonAfterNDays(int[] cells, int N) {		
		var dayByResult = new Dictionary<byte, int>();
		var resultByDay = new List<byte>();

        byte a = 0;
        for(var i = 0; i<8; i++) {
            a += (byte)(cells[7-i] * (1<<i));
        }
		resultByDay.Add(a);
		dayByResult[a] = 0;
        byte b;
		int d;
		Console.WriteLine("0:" + a);
        for(d = 0; d<N; d++) {
			
			b = 0;
			for(var i = 1; i<7; i++) {
				var biti = (a>>(i-1) & 1) ^ (a>>(i+1) & 1);
				biti = biti == 1 ? 0 : 1;
				b += (byte)(biti * (1<<i));
			}
			
            a = b;
			
			if (dayByResult.ContainsKey(b)) {
				break;
			}

			dayByResult[b] = d+1;
			resultByDay.Add(b);
			
			Console.WriteLine((d+1) + ":" + b);
        }
		
		Console.WriteLine("---");
        Console.WriteLine("d="+d);
		Console.WriteLine("a="+a);

		if (d<N) {
			var x = N - d;
			
			var cycleStart = dayByResult[a];
			Console.WriteLine("cycleStart="+cycleStart);

			var cycleSize = d+1 - dayByResult[a];
			Console.WriteLine("cycleSize="+cycleSize);
			
			var remained = x % cycleSize;
			Console.WriteLine("remained="+remained);
			
			var dayIndex = remained==0 ? (cycleStart + cycleSize-1) : cycleStart + remained - 1;

			a = resultByDay[dayIndex];
		}

        Console.WriteLine("result="+a);

        for(var i = 0; i<8; i++) {
            cells[7-i] = ((1<<i) & a)>0 ? 1 : 0;
        }
        return cells;
    }
}

