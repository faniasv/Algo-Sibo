using UnityEngine;
using System;
using AlgoSibo.Core;

namespace AlgoSibo.Player
{
    [Serializable]
    public class Sibo
    {
        public GameObject Prefab;
        public int MoveSpeed = 1;
        private GridPosition gridPosition;
        private Vector3 worldPosition;


        public void SetGridPosition(GridPosition gridPosition)
        {
            this.gridPosition = gridPosition;
        }

        public GridPosition GetGridPosition()
        {
            return gridPosition;
        }

        public void SetWorldPosition(Vector3 worldPosition)
        {
            this.worldPosition = worldPosition;
        }

        public Vector3 GetWorldPosition()
        {
            return worldPosition;
        }
    }
}