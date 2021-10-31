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
            float xSpeed = _stageConstrains.AlienSpeed.x;
            float ySpeed = _stageConstrains.AlienSpeed.y;
            
            _rigidBody.velocity = new Vector3(xSpeed, ySpeed, 0);
        }
    } 
}

