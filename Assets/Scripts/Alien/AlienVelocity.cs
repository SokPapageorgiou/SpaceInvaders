using Commons;
using UnityEngine;

namespace Alien
{
    [RequireComponent(typeof(StageConstrainsLoader))]
    [RequireComponent(typeof(Rigidbody))]
    public class AlienVelocity : MonoBehaviour
    {
        private StageConstrains _stageConstrains;
        private Rigidbody _rigidBody;

        private void Awake()
        {
            _stageConstrains = GetComponent<StageConstrainsLoader>().stageConstrains;
            _rigidBody = GetComponent<Rigidbody>();
        }

        private void FixedUpdate()
        {
            float speed = _stageConstrains.AlienSpeed;
            _rigidBody.velocity = new Vector3(0, speed, 0);
        }
    } 
}

