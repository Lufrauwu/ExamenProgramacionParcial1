using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _playerSpeed = 10;
    [SerializeField] private Rigidbody _rigidBody = default;
    [SerializeField] private float _playerRotation = default;
    [SerializeField] private Transform _playerTransform = default;
    void Start()
    {
        _rigidBody.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            _rigidBody.AddForce(transform.forward * _playerSpeed, ForceMode.Force);
        }
        if (Input.GetKey(KeyCode.S))
        {
            _rigidBody.AddForce(-transform.forward * _playerSpeed / 2, ForceMode.Force);
        }
        if (Input.GetKey(KeyCode.A))
        {
            _playerTransform.Rotate(Vector3.down * _playerRotation * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            _playerTransform.Rotate(Vector3.up * _playerRotation * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            _playerSpeed = 60;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            _playerSpeed = 20;
        }

    }
}
