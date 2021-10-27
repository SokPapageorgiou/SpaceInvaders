using System;
using UnityEngine;

namespace Arsenal
{
    public class Gun : MonoBehaviour
    {
        public static event EventHandler OnShoot;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space)) OnShoot?.Invoke(this,EventArgs.Empty);
        }
    }    
}

