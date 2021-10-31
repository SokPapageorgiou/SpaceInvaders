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
            if (IsOutOfBorder()) _stageConstrains.InvertXSpeed();
            
            float xSpeed = _stageConstrains.AlienSpeed.x;
            float ySpeed = _stageConstrains.AlienSpeed.y;

            _rigidBody.velocity = new Vector3(xSpeed, ySpeed, 0);
        }

        private bool IsOutOfBorder()
        {
            return IsOutOfBorderPositiveX() || IsOutOfBorderNegativeX();
        }

        private bool IsOutOfBorderPositiveX()
        {
            return transform.position.x > _stageConstrains.Border.x && _stageConstrains.AlienSpeed.x > 0;
        }
        
        private bool IsOutOfBorderNegativeX()
        {
            return transform.position.x < _stageConstrains.Border.x * -1 && _stageConstrains.AlienSpeed.x < 0;
        }
    } 
}

