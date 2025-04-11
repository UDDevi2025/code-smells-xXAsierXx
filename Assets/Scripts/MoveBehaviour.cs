using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBehaviour : MonoBehaviour
{

    private Rigidbody playerRigidbody;

    public float MovementSpeed;
    public float RotationSpeed;
    private void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        

        if (Input.GetKey(KeyCode.W))
        {
            // Move forward
            playerRigidbody.MovePosition(transform.position + transform.forward * MovementSpeed * Time.deltaTime * 1);
        }

        if (Input.GetKey(KeyCode.S))
        {
            // Move backward
            playerRigidbody.MovePosition(transform.position + transform.forward * MovementSpeed * Time.deltaTime * -1);
        }

        if (Input.GetKey(KeyCode.A))
        {
            // Rotate left
            playerRigidbody.MoveRotation(Quaternion.Euler(transform.localRotation.eulerAngles + Vector3.up * RotationSpeed * Time.deltaTime * -1));
        }

        if (Input.GetKey(KeyCode.D))
        {
            // Rotate right
            playerRigidbody.MoveRotation(Quaternion.Euler(transform.localRotation.eulerAngles + Vector3.up * RotationSpeed * Time.deltaTime * 1));
        }
    }

}