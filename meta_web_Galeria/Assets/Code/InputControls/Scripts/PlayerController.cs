using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public Camera playerCamera;

    private NewTemplatetInputActions playerInputActions;
    [SerializeField] private GameManager gameManager;
    [SerializeField] private CharacterController controller;

    [SerializeField] private float playerSpeed = 2.0f;

    private bool groundedPlayer;
    private float gravityValue = -9.81f;
    private Vector3 playerVelocity;


    private void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked;

        playerInputActions = gameManager.playerInputActions;

        //playerInputActions = new PlayerInputActions();
        //playerInputActions.Player.Enable();
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

        Vector2 inputVector2 = playerInputActions.Player.Move.ReadValue<Vector2>();
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
}
