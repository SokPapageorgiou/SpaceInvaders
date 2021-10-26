using System;
using Commons;
using UnityEngine;

namespace Player
{
    [RequireComponent(typeof(Rigidbody))]
    [RequireComponent(typeof(StageConstrainsLoader))]
    public class Movement : MonoBehaviour
    {
        [SerializeField] private float speed;
        private Vector3 _border;
        private Rigidbody _rigidbody;

        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>();
            _border = GetComponent<StageConstrainsLoader>().stageConstrains.Border;
        }

        private void FixedUpdate()
        {
            MovePlayer();
        }

        private void MovePlayer()
        {
            _rigidbody.velocity = SetMovementDirection(Input.GetAxis("Horizontal")) * speed;
        }

        private Vector3 SetMovementDirection(float xInput)
        {
            xInput = CancelInvalidInput(xInput);

            return new Vector3(xInput, 0, 0);
        }

        private float CancelInvalidInput(float xInput)
        {
            if (IsInputPositiveInvalid(xInput)) xInput = 0;
            else if (IsInputNegativeInvalid(xInput)) xInput = 0;
            return xInput;
        }

        private bool IsInputPositiveInvalid(float xInput)
        {
            return this.transform.position.x > _border.x && xInput > 0;
        }

        private bool IsInputNegativeInvalid(float xInput)
        {
            return this.transform.position.x < _border.x * -1 && xInput < 0;
        }
    }    
}

