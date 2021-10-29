using System.Collections.Generic;
using Commons;
using UnityEngine;

namespace Grid
{
    [RequireComponent(typeof(GridStatsLoader))]
    public class GridCreator : MonoBehaviour
    {
        [SerializeField] private Vector2 _gridSize;
        
        private StageConstrains _stageConstrains;
        private Queue<GameObject> _alienArmy;
        private GameObject _alien;

        private void Awake()
        {
            LoadComponents();
            CreatePool();
            PlaceObjects();
        }

        private void LoadComponents()
        {
            GridStatsLoader temp = GetComponent<GridStatsLoader>();
            _alien = temp.alien;
        }

        private void CreatePool()
        {
            _alienArmy = ObjectPool.Create(_alien, ArmySize());
        }

        private int ArmySize()
        {
            return (int) (_gridSize.x * _gridSize.y);
        }

        private void PlaceObjects()
        {
            float pointA;
            
            foreach (GameObject alien in _alienArmy)
            {
                
            }
        }
    }
}
