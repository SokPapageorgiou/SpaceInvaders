using System.Collections.Generic;
using Commons;
using UnityEngine;

namespace Grid
{
    [RequireComponent(typeof(GridStatsLoader))]
    public class GridCreator : MonoBehaviour
    {
        private GridStats _gridStats;
        private Queue<GameObject> _alienArmy;
        private GameObject _alien;

        private void Awake()
        {
            GridStatsLoader temp = GetComponent<GridStatsLoader>();
            _gridStats = temp.gridStats;
            _alien = temp.alien;

            _alienArmy = ObjectPool.Create(_alien, _gridStats.TotalUnities());
        }
    }
}
