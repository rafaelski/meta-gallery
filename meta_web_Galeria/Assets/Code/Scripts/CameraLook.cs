using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Cinemachine.CinemachineVirtualCamera))]
public class CameraLook : MonoBehaviour
{

    private Cinemachine.CinemachineVirtualCamera cinemachine;
    private Cinemachine.CinemachineFreeLook freeLook;

    [SerializeField] private GameManager gameManager;
    private NewTemplatetInputActions playerInputActions;


    private void Awake()
    {
        playerInputActions = gameManager.playerInputActions;
    }

    private void Update()
    {
        //Vector2 delta = playerInputActions.Player.Look.ReadValue<Vector2>();
        //cinemachine.GetInputAxisProvider();
        //freeLook.m_XAxis
    }


}
