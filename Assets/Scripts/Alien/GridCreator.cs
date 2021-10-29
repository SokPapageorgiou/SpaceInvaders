using System.Collections.Generic;
using Commons;
using UnityEngine;
using UnityEngine.Serialization;

namespace Grid
{
    [RequireComponent(typeof(GridStatsLoader))]
    public class GridCreator : MonoBehaviour
    {
        [SerializeField] private Vector2 gridSize;
        
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
            _stageConstrains = temp.stageConstrains;
            _alien = temp.alien;
        }

        private void CreatePool()
        {
            _alienArmy = ObjectPool.Create(_alien, ArmySize());
        }

        private int ArmySize()
        {
            return (int) (gridSize.x * gridSize.y);
        }

        private void PlaceObjects()
        {
            for (int i = 0; i < gridSize.y; i++)
            {
                for (int j = 0; j < gridSize.x; j++)
                {
                    GameObject temp = _alienArmy.Dequeue();
                    temp.SetActive(true);
                    
                    temp.transform.position = SetPosition(j);
                    
                    _alienArmy.Enqueue(temp);
                }
            }
        }

        private Vector3 SetPosition(int j)
        {
            float xOffset = CalculateXOffset();
            float x = CalculateXPosition(j);
            
            return new Vector3(x - xOffset,0,0);
        }

        private float CalculateXOffset()
        {
            return _stageConstrains.Border.x / gridSize.x;
        }

        private float CalculateXPosition(int counter)
        {
            return _stageConstrains.Border.x * (1 - (2  * counter)/gridSize.x);
        }
    }
}
