using System;
using UnityEngine;

namespace Arsenal
{
    public class Gun : MonoBehaviour
    {
        private event EventHandler OnShoot;

        private void Update()
        {
            if (Input.GetKeyDown("Space")) OnShoot?.Invoke(this,EventArgs.Empty);
        }
    }    
}

