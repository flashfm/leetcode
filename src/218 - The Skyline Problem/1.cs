// Copyright (c) 2020 Alexey Filatov
// 218 - The Skyline Problem (https://leetcode.com/problems/the-skyline-problem)
// Date solved: 8/27/2020 7:02:50 AM +00:00
// Memory: 39 MB
// Runtime: 304 ms


// critical points are all rect lefts and rights, sorted by X
// rember was it left or right and what is height of that rect

// foreach critical points (sorted by X)
// if it's rect left then add rect height to heap -> output top
// if it's rect right then remove from heap -> output top
// (actually output only if Y is changed)

    public class Solution {
        public struct Point
        {
            public int X;
            public int Y;
            public bool IsLeft;
        }

        private Heap heap = new Heap(false);

        public IList<IList<int>> GetSkyline(int[][] buildings) {
            var points = new List<Point>();
            foreach(var b in buildings) {
                var l = b[0];
                var r = b[1];
                var h = b[2];
                points.Add(new Point { X = l, Y = h, IsLeft = true });
                points.Add(new Point { X = r, Y = h });                
            }
            var result = new Stack<IList<int>>();

            points = points.OrderBy(p => p.X).ToList();
            //  var pts = points
            //      .GroupBy(p => (p.X,!p.IsLeft))
            //      .OrderBy(g => g.Key.X)
            //      .Select(g => g.OrderByDescending(p => p.Y).First())
            //      .ToList();

            for(var i = 0; i<points.Count; i++) {
                var point = points[i];
                if (point.IsLeft) {
                    heap.Add(point.Y);
                }
                else {
                    heap.Remove(point.Y);
                }
                var top = heap.Count>0 ? heap.Top : 0;

                if (result.Count>0) {
                    var peek = result.Peek();
                    if (point.X == peek[0] && (point.IsLeft && point.Y >= peek[1] || !point.IsLeft && point.Y <= peek[1])) {
                        result.Pop();
                    }
                }

                if (result.Count==0 || result.Peek()[1]!=top) {
                    result.Push(new[] { point.X, top });
                }
            }

            return result.Reverse().ToArray();
        }
    }



    public class Heap
    {
        private class Item: IComparer<Item>
        {
            public int Val;
            private Guid Guid = Guid.NewGuid();

            public int Compare(Item x, Item y)
                => x.Val == y.Val ? x.Guid.CompareTo(y.Guid) : x.Val.CompareTo(y.Val);
        }

        private readonly bool isMin;
        private readonly SortedSet<Item> items = new SortedSet<Item>(new Item());
        private readonly Dictionary<int, List<Item>> itemsByVal = new Dictionary<int, List<Item>>();

        public int Top => isMin ? items.Min.Val : items.Max.Val;
        public int Count => items.Count;

        public void Add(int val)
        {
            var item = new Item { Val = val };
            items.Add(item);

            if (!itemsByVal.TryGetValue(val, out var list)) {
                itemsByVal[val] = list = new List<Item>();
            }
            list.Add(item);
        }

        public int Pop()
        {
            var item = isMin ? items.Min : items.Max;
            items.Remove(item);
            itemsByVal[item.Val].Remove(item);
            return item.Val;
        }

        public void Remove(int val)
        {
            if (!itemsByVal.TryGetValue(val, out var list)) {
                return;
            }
            if (list.Count==0) {
                return;
            }
            var item = list[list.Count-1];
            list.RemoveAt(list.Count-1);
            items.Remove(item);
        }

        public Heap(bool isMin)
        {
            this.isMin = isMin;
        }
    }

