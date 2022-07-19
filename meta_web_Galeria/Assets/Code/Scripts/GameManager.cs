using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;


public class GameManager : MonoBehaviour
{

    public NewTemplatetInputActions playerInputActions;


    private void Awake()
    {
        playerInputActions = new NewTemplatetInputActions();
        //playerInputActions.UI.Enable();
    }

    private void OnEnable()
    {
        playerInputActions.Enable();
    }

    private void OnDisable()
    {
        playerInputActions.Disable();
    }


    

}




