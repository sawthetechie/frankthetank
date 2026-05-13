using System;
using UnityEngine;

namespace Script
{
    public class GridSpawner : MonoBehaviour
    {
        public int gridHeight;
        public int gridWidth;
        public int nodeSize;
        
        Node[,]  gridNodeList;

        private void OnValidate()
        {
            gridNodeList = FetchNode(gridHeight, gridWidth);
        }

        void Start()
        {
           
        }

        private Node[,] FetchNode(int gridWidth, int gridHeight)
        {
            return Grid.GenerateGridData(gridWidth, gridHeight);
        }

        private void OnDrawGizmos()
        {
            for (int x = 0; x < gridWidth; x++)
            {
                for (int y = 0; y < gridHeight; y++)
                {
                    
                }
            }
        }
    }
}