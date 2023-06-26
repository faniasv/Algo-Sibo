using UnityEngine;

namespace AlgoSibo.Core
{
    public class GridObject
    {
        private GridSystem gridSystem;
        private GridPosition gridPosition;
        private int visitedCount = 0;

        public GridObject(GridSystem gridSystem, GridPosition gridPosition)
        {
            this.gridSystem = gridSystem;
            this.gridPosition = gridPosition;
        }

        public void IncrementVisitedCount()
        {
            visitedCount++;
        }

        public void ResetVisitedCount()
        {
            visitedCount = 0;
        }

        public override string ToString()
        {
            return gridPosition.ToString();
        }
    }
}