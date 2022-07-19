using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;


public class GameManager : MonoBehaviour
{

    public NewTemplatetInputActions inputActions;


    private void Awake()
    {
        inputActions = new NewTemplatetInputActions();
        inputActions.Player.Enable();
    }

    private void OnEnable()
    {
        inputActions.Enable();
    }

    private void OnDisable()
    {
        inputActions.Disable();
    }


    

}




