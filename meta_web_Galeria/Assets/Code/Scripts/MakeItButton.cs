using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class MakeItButton : MonoBehaviour
{

    public NewTemplatetInputActions playerInputActions;
    [SerializeField] private GameManager gameManager;

    public UnityEvent unityEvent = new UnityEvent();

    private Camera mainCamera;
    private GameObject button;


    private void Start()
    {
        button = this.gameObject;
        mainCamera = Camera.main;
        playerInputActions = gameManager.inputActions;
    }


    private void Update()
    {
        Ray ray = mainCamera.ScreenPointToRay(playerInputActions.Targets.ClickTarget.ReadValue<Vector2>());
        RaycastHit hit;

        if (playerInputActions.UI.Click.WasPerformedThisFrame())
        {
            if (Physics.Raycast(ray, out hit) && hit.collider.gameObject == button)
            {
                unityEvent.Invoke();
            }
        }        
    }






}
