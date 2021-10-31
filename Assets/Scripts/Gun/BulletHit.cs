using UnityEngine;

namespace Arsenal
{
    public class BulletHit : MonoBehaviour
    {
        private void OnCollisionEnter(Collision other)
        {
            other.gameObject.SetActive(false);
            this.gameObject.SetActive(false);
        }
    }    
}

