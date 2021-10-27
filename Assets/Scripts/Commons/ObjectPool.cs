using System.Collections.Generic;
using UnityEngine;

namespace Commons
{
    public class ObjectPool
    {
        public static Queue<GameObject> Create(GameObject gameObject, int poolSize, Transform parent)
        {
            Queue<GameObject> pool = new Queue<GameObject>();

            for (int i = 0; i < poolSize; i++)
            {
                GameObject temp = Object.Instantiate(gameObject, parent);
                pool.Enqueue(temp);
            }
            
            Debug.Log(pool.Count);
            
            return pool;
        }
    }
}