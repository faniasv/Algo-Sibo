using UnityEngine;

namespace AlgoSibo.Core
{
    public class GridSystem
    {
        private int width;
        private int height;
        private float cellSize;
        private GridObject[,] gridObjectArray;

        public GridSystem(int width, int height, float cellSize)
        {
            this.width = width;
            this.height = height;
            this.cellSize = cellSize;
            gridObjectArray = new GridObject[width, height];

            for (int x = 0; x < width; x++)
            {
                for (int z = 0; z < height; z++)
                {
                    GridPosition gridPosition = new GridPosition(x, z);
                    gridObjectArray[x, z] = new GridObject(this, gridPosition);
                }
            }
        }

        public int GetWidth()
        {
            return width;
        }

        public int GetHeight()
        {
            return height;
        }

        public GridPosition GetGridPosition(Vector3 worldPosition)
        {
            return new GridPosition(Mathf.RoundToInt(worldPosition.x / cellSize), Mathf.RoundToInt(worldPosition.z / cellSize));
        }

        public Vector3 GetWorldPosition(GridPosition gridPosition)
        {
            return new Vector3(gridPosition.x, 0, gridPosition.z) * cellSize;
        }

        public void CreateDebugObjects(Transform gridDebugPrefab, Transform parent = null)
        {
            for (int x = 0; x < width; x++)
            {
                for (int z = 0; z < height; z++)
                {
                    GridPosition gridPosition = new GridPosition(x, z);

                    Transform debugTransform = GameObject.Instantiate(gridDebugPrefab, GetWorldPosition(gridPosition), Quaternion.identity, parent);

                    GridDebug gridDebugObject = debugTransform.GetComponent<GridDebug>();
                    gridDebugObject.SetGridObject(GetGridObject(gridPosition));
                }
            }
        }

        public GridObject GetGridObject(GridPosition _gridPosition)
        {
            return gridObjectArray[_gridPosition.x, _gridPosition.z];
        }

        public bool IsValidGridPosition(GridPosition _gridPosition)
        {
            return _gridPosition.x >= 0 &&
                   _gridPosition.z >= 0 &&
                   _gridPosition.x < width &&
                   _gridPosition.z < height;
        }
    }

}
