using System.Collections.Generic;
using UnityEngine;

namespace Commons
{
    public static class ObjectPool
    {
        public static Queue<GameObject> Create(GameObject gameObject, int poolSize)
        {
            Queue<GameObject> pool = new Queue<GameObject>();

            for (int i = 0; i < poolSize; i++)
            {
                GameObject temp = Object.Instantiate(gameObject);
                temp.SetActive(false);
                pool.Enqueue(temp);
            }
            
            return pool;
        }
        
        public static Queue<GameObject> Create(GameObject gameObject, int poolSize, Transform parent)
        {
            Queue<GameObject> pool = new Queue<GameObject>();

            for (int i = 0; i < poolSize; i++)
            {
                GameObject temp = Object.Instantiate(gameObject, parent);
                temp.SetActive(false);
                pool.Enqueue(temp);
            }
            
            return pool;
        }
    }
}