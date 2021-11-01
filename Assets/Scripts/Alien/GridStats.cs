using JetBrains.Annotations;
using UnityEngine;

namespace Grid
{
    [CreateAssetMenu(menuName = "ScriptableObjects/Grid/Stats", fileName = "GridStats")]
    public class GridStats : ScriptableObject
    {
        [SerializeField] private Vector2 gridSize;
        private GameObject[,] _cellElements;

        public Vector2 GridSize => gridSize;

        public GameObject[,] CellPositions => _cellElements;
        
        public void InitiateCellPosition()
        {
            _cellElements = new GameObject[(int) gridSize.x, (int) gridSize.y];
        }

        public void PopulateCellPosition(int j, int i, GameObject currentObject)
        {
            _cellElements[j, i] = currentObject;
        }

        public void PrintOutPositions()
        {
            for (int i = 0; i < _cellElements.GetLength(1); i++)
            {
                for (int j = 0; j < _cellElements.GetLength(0); j++)
                {
                    Debug.Log($"{j}, {i}: {_cellElements[j, i].transform.position}");
                }
            }
        }
    }
}
