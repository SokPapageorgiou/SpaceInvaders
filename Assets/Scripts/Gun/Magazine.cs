using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Serialization;

namespace Arsenal
{
    [RequireComponent(typeof(Gun))]
    public class Magazine : MonoBehaviour
    {
        [SerializeField] private GameObject bullet;
        
        private void Awake()
        {
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

