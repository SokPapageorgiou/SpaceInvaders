using UnityEngine;

namespace Grid
{
    [CreateAssetMenu(menuName = "ScriptableObjects/Alien/Grid", fileName = "GridStats")]
    public class GridStats : ScriptableObject
    {
        [SerializeField] private Vector2 gridSize;

        public Vector2 GridSize => gridSize;

        public int TotalUnities()
        {
            return (int)(gridSize.x * gridSize.y);
        }
    }    
}

