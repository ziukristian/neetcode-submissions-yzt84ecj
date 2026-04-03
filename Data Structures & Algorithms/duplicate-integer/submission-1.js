class Solution {
    /**
     * @param {number[]} nums
     * @return {boolean}
     */
    hasDuplicate(nums) {
        let m = new Set()
        for(let n of nums){
            if(m.has(n)) return true
            m.add(n)
        }
        return false
    }
}
