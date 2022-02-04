using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public VariableJoystick variableJoystick;
    private CharacterController controller;
    [SerializeField]
    private float playerSpeed = 2.0f;
    private Vector3 playerVelocity;

    private void Awake()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        //Joystick Input system
        Vector3 move = Vector3.right * variableJoystick.Horizontal;        
        controller.Move(move * Time.deltaTime * playerSpeed);

        //Forward force
        playerVelocity.z = playerSpeed;
        controller.Move(playerVelocity * Time.deltaTime);

        if (move != Vector3.zero)
        {
            gameObject.transform.forward = move;
        }
    }
}
