// Insert Delete GetRandom O(1)
// https://leetcode.com/problems/insert-delete-getrandom-o1
// Date solved: 12/29/2019 08:16:26 +00:00

public class RandomizedSet {
    
    private List<int> list = new List<int>();
    private Dictionary<int, int> indexByVal = new Dictionary<int, int>();
    private Random random = new Random();

    /** Initialize your data structure here. */
    public RandomizedSet() {
        
    }
    
    /** Inserts a value to the set. Returns true if the set did not already contain the specified element. */
    public bool Insert(int val) {
        if (indexByVal.ContainsKey(val)) {
            return false;
        }
        list.Add(val);
        indexByVal[val] = list.Count-1;
        return true;
    }
    
    /** Removes a value from the set. Returns true if the set contained the specified element. */
    public bool Remove(int val) {
        if (!indexByVal.ContainsKey(val)) {
            return false;
        }
        var i = indexByVal[val];
        indexByVal.Remove(val);
                
        if (i!=list.Count-1 && list.Count>1) {
            var lastVal = list[list.Count-1];
            list[i] = lastVal;
            indexByVal[lastVal] = i;
        }
        list.RemoveAt(list.Count-1);

        return true;
    }
    
    /** Get a random element from the set. */
    public int GetRandom() {
        var j = random.Next(list.Count);
        return list[j];
    }
}

/**
 * Your RandomizedSet object will be instantiated and called as such:
 * RandomizedSet obj = new RandomizedSet();
 * bool param_1 = obj.Insert(val);
 * bool param_2 = obj.Remove(val);
 * int param_3 = obj.GetRandom();
 */
