/**
 * Pair class to store key-value pairs
 */
// class Pair {
//     /**
//      * @param {number} key The key to be stored in the pair
//      * @param {string} value The value to be stored in the pair
//      */
//     constructor(key, value) {
//         this.key = key;
//         this.value = value;
//     }
// }
class Solution {
    /**
     * @param {Pair[]} pairs
     * @returns {Pair[][]}
     */
    insertionSort(pairs) {

        if(!pairs.length) return []

        let res = [JSON.parse(JSON.stringify(pairs))]

        for(let i=1;i<pairs.length;i++){
            for(let j=i;j>0;j--){
                if(pairs[j].key < pairs[j-1].key){
                    let temp = pairs[j]
                    pairs[j] = pairs[j-1]
                    pairs[j-1] = temp
                }
                else {
                    break;
                }
            }

            res.push(JSON.parse(JSON.stringify(pairs)))

        }

        return res
    }
}
