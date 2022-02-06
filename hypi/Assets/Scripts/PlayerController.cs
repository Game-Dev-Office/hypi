using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public VariableJoystick variableJoystick;
    private CharacterController controller;
    [SerializeField]
    private float playerSpeed = 5f;
    [SerializeField]
    private float rotationSpeed = 5f;
    [SerializeField]
    private float sideSpeed = 2f;

    private void Awake()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        // Handle Movement
        var direction = new Vector3(variableJoystick.Horizontal * sideSpeed, 0, playerSpeed);
        transform.position += direction * Time.deltaTime;

        // Handle Rotation
        var currRotation = transform.rotation;
        var targetRotation = Quaternion.Euler(new Vector3(0, Mathf.Atan2(variableJoystick.Horizontal, variableJoystick.Vertical) * 90 / Mathf.PI, 0));
        transform.rotation = Quaternion.Lerp(currRotation, targetRotation, Time.deltaTime * rotationSpeed);
    }
}
