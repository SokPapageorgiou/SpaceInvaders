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

        public void PopulateCell(int j, int i, GameObject currentObject)
        {
            _cellElements[j, i] = currentObject;
        }
    }
}
