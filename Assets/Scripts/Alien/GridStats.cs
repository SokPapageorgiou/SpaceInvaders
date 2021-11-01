using UnityEngine;

namespace Grid
{
    [CreateAssetMenu(menuName = "ScriptableObjects/Grid/Stats", fileName = "GridStats")]
    public class GridStats : ScriptableObject
    {
        [SerializeField] private Vector2 gridSize;
        private Vector2[,] _cellPositions;

        public Vector2 GridSize => gridSize;

        public Vector2[,] CellPositions => _cellPositions;
        
        public void InitiateCellPosition()
        {
            _cellPositions = new Vector2[(int) gridSize.x, (int) gridSize.y];
        }

        public void PopulateCellPosition(int j, int i, Vector3 currentPosition)
        {
            _cellPositions[j, i] = currentPosition;
        }

        public void PrintOutPositions()
        {
            for (int i = 0; i < _cellPositions.GetLength(1); i++)
            {
                for (int j = 0; j < _cellPositions.GetLength(0); j++)
                {
                    Debug.Log($"{j}, {i}: {_cellPositions[j, i]}");
                }
            }
        }
    }
}
