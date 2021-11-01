using UnityEngine;

namespace Grid
{
    [CreateAssetMenu(menuName = "ScriptableObjects/Grid/Stats", fileName = "GridStats")]
    public class GridStats : ScriptableObject
    {
        [SerializeField] private Vector2 gridSize;

        public Vector2 GridSize => gridSize;
    }
    
}
