using UnityEngine;
using System.Collections.Generic;
using AlgoSibo.Core;
using AlgoSibo.Currency;
using AlgoSibo.Player;

namespace AlgoSibo.Level
{
    [CreateAssetMenu(fileName = "NewLevel", menuName = "AlgoSibo/Level/New Level", order = 0)]
    public class LevelSO : ScriptableObject
    {
        [Header("Level")]
        public string levelName;
        public MoneySO money;

        [Header("Grid")]
        public int width;
        public int height;
        public float cellSize;
        private GridSystem gridSystem;

        [Header("Sibo")]
        public Sibo sibo;
        public GridPosition siboStartPosition;

        [Header("Shop")]
        public GridPosition shopPosition;

        [Header("Factory")]
        public List<GridPosition> factoryPositions;

        public GridSystem GetGridSystem()
        {
            if (gridSystem == null)
            {
                gridSystem = new GridSystem(width, height, cellSize);
            }
            return gridSystem;
        }

        public void SpawnSibo(Transform parent)
        {
            GameObject siboObject = GameObject.Instantiate(sibo.Prefab.gameObject, gridSystem.GetWorldPosition(siboStartPosition), Quaternion.identity, parent);
            sibo = siboObject.GetComponent<Sibo>();
            sibo.SetGridPosition(siboStartPosition);
        }

        // public void SpawnShop(Transform parent)
        // {
        //     GameObject shopObject = GameObject.Instantiate(money.shopPrefab, gridSystem.GetWorldPosition(shopPosition), Quaternion.identity, parent);
        //     Shop shop = shopObject.GetComponent<Shop>();
        //     shop.SetGridPosition(shopPosition);
        // }

        // public void SpawnFactory(Transform parent)
        // {
        //     foreach (GridPosition factoryPosition in factoryPositions)
        //     {
        //         GameObject factoryObject = GameObject.Instantiate(money.factoryPrefab, gridSystem.GetWorldPosition(factoryPosition), Quaternion.identity, parent);
        //         Factory factory = factoryObject.GetComponent<Factory>();
        //         factory.SetGridPosition(factoryPosition);
        //     }
        // }

        public void SpawnGridDebugObjects(Transform gridDebugPrefab, Transform parent = null)
        {
            gridSystem.CreateDebugObjects(gridDebugPrefab, parent);
        }

        public void MoveSibo(GridPosition gridPosition)
        {
            sibo.SetGridPosition(gridPosition);
        }
    }
}