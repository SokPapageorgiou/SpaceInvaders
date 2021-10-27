using System.Collections.Generic;
using UnityEngine;

namespace Commons
{
    public class ObjectPool
    {
        public static Queue<GameObject> Create(GameObject gameObject, int poolSize)
        {
            Queue<GameObject> pool = new Queue<GameObject>();

            for (int i = 0; i < poolSize; i++)
            {
                GameObject temp = Object.Instantiate(gameObject);
                pool.Enqueue(temp);
            }
            
            Debug.Log(pool.Count);
            
            return pool;
        }
    }
}