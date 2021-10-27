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
        [SerializeField] private int magazineSize;

        private Queue<GameObject> _magazine;
        private GameObject _tempBullet;

        private void Awake()
        {
            _magazine = ObjectPool.Create(bullet, magazineSize, this.transform);
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
            FireUp();
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

        private void FireUp()
        {
            Debug.Log("I am flying!!!");
        }
    }    
}

