using System;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class BulletMovement : MonoBehaviour
{

    [SerializeField] private Vector3 forceVector;
    [SerializeField] private float thrust;

    private Rigidbody _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void OnEnable()
    {
        _rigidbody.AddForce(forceVector * thrust);
    }
}
