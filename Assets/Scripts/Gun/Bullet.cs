using System;
using System.Collections.Generic;
using Commons;
using UnityEngine;


namespace Arsenal
{
    [RequireComponent(typeof(Gun))]
    public class Bullet : MonoBehaviour
    {
        [SerializeField] private GameObject bullet;

        private Queue<GameObject> magazine;

        private void Awake()
        {
            magazine = ObjectPool.Create(bullet, 10);
            Gun.OnShoot += ShootBullet;
        }

        private void ShootBullet(object sender, EventArgs e)
        {
            SetPositionToOrigin();
            Activate();
        }

        private void SetPositionToOrigin()
        {
            bullet.transform.position = this.transform.position;
        }

        private void Activate()
        {
            bullet.SetActive(true);
        }
    }    
}

