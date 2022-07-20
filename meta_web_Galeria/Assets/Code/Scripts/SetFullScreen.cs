using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class SetFullScreen : MonoBehaviour
{

    public NewTemplatetInputActions playerInputActions;
    [SerializeField] private GameManager gameManager;


    private void Start() => playerInputActions = gameManager.inputActions;


    void Update()
    {
        if (playerInputActions.UI.tecla_1.WasPressedThisFrame())
        {
            Screen.autorotateToPortrait = false;
            Screen.autorotateToPortraitUpsideDown = false;
            Screen.autorotateToLandscapeRight = false;
            Screen.autorotateToLandscapeLeft = true;
            Screen.orientation = ScreenOrientation.LandscapeLeft;
            Screen.fullScreen = true;
        }

        if (playerInputActions.UI.tecla_2.WasPerformedThisFrame())
        {
            Screen.autorotateToPortrait = false;
            Screen.autorotateToPortraitUpsideDown = false;
            Screen.autorotateToLandscapeRight = false;
            Screen.autorotateToLandscapeLeft = true;
            Screen.orientation = ScreenOrientation.LandscapeLeft;
            Screen.fullScreen = true;
        }
    }
}
