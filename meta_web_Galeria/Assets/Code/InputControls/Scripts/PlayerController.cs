using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public Camera playerCamera;

    private Rigidbody capsuleRigidbody;
    private PlayerInputActions playerInputActions;

    [SerializeField] private CharacterController controller;
    [SerializeField] private Vector3 playerVelocity;
    [SerializeField] private bool groundedPlayer;
    [SerializeField] private float playerSpeed = 2.0f;
    [SerializeField] private float jumpHeight = 1.0f;
    [SerializeField] private float gravityValue = -9.81f;


    private void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked;

        capsuleRigidbody = GetComponent<Rigidbody>();

        playerInputActions = new PlayerInputActions();
        playerInputActions.Player.Enable();
        //playerInputActions.Player.Jump.performed += Jump;
    }


    void Update()
    {
        MovePlayerByInput();
    }


    private void MovePlayerByInput()
    {
        groundedPlayer = controller.isGrounded;
        if (groundedPlayer && playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;
        }

        Vector2 inputVector2 = playerInputActions.Player.Movement.ReadValue<Vector2>();
        Vector3 move = (playerCamera.transform.forward * inputVector2.y + playerCamera.transform.right * inputVector2.x);
        move.y = 0f;
        controller.Move(move * Time.deltaTime * playerSpeed);


        if (move != Vector3.zero)
        {
            gameObject.transform.forward = move;
        }

        playerVelocity.y += gravityValue * Time.deltaTime;
        controller.Move(playerVelocity * Time.deltaTime);
    }




    //private void MovePlayerByInput(Vector2 _input)
    //{
    //    Vector2 inputVector2 = _input;
    //    float speed = 10f;

    //    Vector3 forward = playerCamera.transform.TransformDirection(Vector3.forward);
    //    forward.y = 0;
    //    forward = forward.normalized;
    //    Vector3 right = new Vector3(forward.z, 0, -forward.x);

    //    Vector3 moveDirection = (inputVector2.x * right + inputVector2.y * forward);
    //    moveDirection = Quaternion.Inverse(this.transform.rotation) * moveDirection;
    //    moveDirection = new Vector3(moveDirection.x, 0, moveDirection.z);

    //    //moveDirection = this.transform.rotation * moveDirection;
    //    capsuleRigidbody.AddForce(moveDirection * speed, ForceMode.Force);
    //}


    public void Jump(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            capsuleRigidbody.AddForce(Vector3.up * 4f, ForceMode.Impulse);
        }
    }


}
