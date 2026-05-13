using UnityEngine;
namespace Script
{
    public static class Grid
    {
        private static Node[,] gridNodeList;

        public static Node[,] GenerateGridData(int gridWidth, int gridHeight)
        {
            Node[,] nodeData = new Node[gridWidth, gridHeight];
            for (int x = 0; x < gridWidth; x++)
            {
                for (int y = 0; y < gridHeight; y++)
                {
                    nodeData[x, y] = new Node(x, y);
                }
            }

            return gridNodeList;
        }


    }
}
