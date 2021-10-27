using System;
using System.Collections.Generic;
using Commons;
using UnityEngine;

namespace Arsenal
{
    public class BulletFire : MonoBehaviour
    {
        [SerializeField] private GameObject bullet;
        [SerializeField] private int magazineSize;

        private Queue<GameObject> _magazine;
        private GameObject _tempBullet;

        private void Awake()
        {
            _magazine = ObjectPool.Create(bullet, magazineSize);
            Gun.OnShoot += ShootBullet;
        }

        private void ShootBullet(object sender, EventArgs e)
        {
            LoadAndFire();
        }

        private void LoadAndFire()
        {
            _tempBullet = _magazine.Dequeue();
            SetPositionToOrigin();
            Activate();
            _magazine.Enqueue(_tempBullet);
        }

        private void SetPositionToOrigin()
        {
            _tempBullet.transform.position = this.transform.position;
        }

        private void Activate()
        {
            _tempBullet.SetActive(true);
        }
    }    
}

