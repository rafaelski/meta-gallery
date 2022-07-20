using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.ResourceManagement.AsyncOperations;


public class SetFullScreen : MonoBehaviour
{

    public NewTemplatetInputActions playerInputActions;
    [SerializeField] private GameManager gameManager;


    private void Start() => playerInputActions = gameManager.inputActions;


    void Update()
    {
        if (playerInputActions.UI.tecla_1.WasPressedThisFrame())
        {
            Screen.fullScreen = true;
            Screen.orientation = ScreenOrientation.LandscapeLeft;
        }

        if (playerInputActions.UI.tecla_2.WasPerformedThisFrame())
        {
            Screen.fullScreen = true;
            Screen.orientation = ScreenOrientation.LandscapeLeft;
        }
    }
}
