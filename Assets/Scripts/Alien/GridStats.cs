using Commons;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/Alien/Grid", fileName = "GridStats")]
public class GridStats : ScriptableObject
{
    [SerializeField] private Vector2 gridSize;

    public Vector2 GridSize => gridSize;
}
