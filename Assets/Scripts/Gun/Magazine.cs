using System;
using UnityEngine;

namespace Arsenal
{
    [RequireComponent(typeof(Gun))]
    public class Magazine : MonoBehaviour
    {
        private void Awake()
        {
            Gun.OnShoot += BulletMovement;
        }

        private void BulletMovement(object sender, EventArgs e)
        {
            Debug.Log("I am flying!!!");
        }
    }    
}

