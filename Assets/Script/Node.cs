using UnityEngine;

namespace Script
{
    public class Node
    {
        public int x, y;
        public int nodeSize;
        public bool nodeIsActive;

        public Node(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}