public class Solution {
    public Node copyRandomList(Node head) {

        if (head == null)
            return null;

        var numberingDict = new Dictionary<Node, int>();
        var helperDict = new Dictionary<int, (int val, int? nextIndex, int? randomIndex)>();
        var newListDict = new Dictionary<int, Node>();

        // 1️⃣ First pass — assign each node an index
        int index = 0;
        var current = head;

        while (current != null)
        {
            numberingDict[current] = index;
            current = current.next;
            index++;
        }

        int total = index;

        // 2️⃣ Second pass — store val, nextIndex, randomIndex
        foreach (var kv in numberingDict)
        {
            var node = kv.Key;
            int i = kv.Value;

            int? nextIndex = node.next == null ? null : numberingDict[node.next];
            int? randomIndex = node.random == null ? null : numberingDict[node.random];

            helperDict[i] = (node.val, nextIndex, randomIndex);
        }

        // 3️⃣ Third pass — create all new nodes
        for (int i = 0; i < total; i++)
            newListDict[i] = new Node(0);

        // 4️⃣ Fourth pass — assign val, next, random
        for (int i = 0; i < total; i++)
        {
            var data = helperDict[i];
            var newNode = newListDict[i];

            newNode.val = data.val;

            newNode.next = data.nextIndex == null ? null : newListDict[data.nextIndex.Value];
            newNode.random = data.randomIndex == null ? null : newListDict[data.randomIndex.Value];
        }

        return newListDict[0];
    }
}
