class Solution {
    /**
     * @param {string} s
     * @param {string} t
     * @return {boolean}
     */
    isAnagram(s, t) {
        if(s.length != t.length) return false
            let m = new Map();

    for(let c of s) {
        console.log("C:", c);
        console.log(m);
        if(m.has(c)) {
            console.log("Has c");
            m.set(c, m.get(c) + 1);
            console.log(m.get(c));
        } else {
            console.log("No c");
            m.set(c, 1);
        }
    }

    console.log(m);

    for(let c of t) {
        if(!m.has(c) || m.get(c) == 0) return false;
        m.set(c, m.get(c) - 1);
    }

    return true;
    }
}
