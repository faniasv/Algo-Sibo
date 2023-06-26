using System;
using UnityEngine;
using AlgoSibo.Level;
using AlgoSibo.Player;

namespace AlgoSibo.Core
{
    public class LevelGrid : MonoBehaviour
    {
        [Header("Debug")]
        [SerializeField] private Transform gridDebugPrefab;
        [Header("Level")]
        [SerializeField] private LevelSO levelObject;
        private GridSystem gridSystem;

        private void Awake()
        {
            gridSystem = levelObject.GetGridSystem();
        }

        private void Start()
        {
            InitializeGridDebug();
        }

        private void InitializeGridDebug()
        {
            gridSystem.CreateDebugObjects(gridDebugPrefab);
        }

        public void IncrementVisitedCountAtGridPosition(GridPosition gridPosition)
        {
            GridObject gridObject = gridSystem.GetGridObject(gridPosition);
            gridObject.IncrementVisitedCount();
        }

        public void ResetVisitedCountAtGridPosition(GridPosition gridPosition)
        {
            GridObject gridObject = gridSystem.GetGridObject(gridPosition);
            gridObject.ResetVisitedCount();
        }

        public GridPosition GetGridPosition(Vector3 worldPosition)
        {
            return gridSystem.GetGridPosition(worldPosition);
        }

        public Vector3 GetWorldPosition(GridPosition gridPosition)
        {
            return gridSystem.GetWorldPosition(gridPosition);
        }

        public bool IsValidGridPosition(GridPosition gridPosition)
        {
            return gridSystem.IsValidGridPosition(gridPosition);
        }
    }
}