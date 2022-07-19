using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using Cinemachine;

public class CinemachineUITouchProtector : MonoBehaviour
{

    [SerializeField] CinemachineInputProvider cinemachine;


    void Update()
    {
        cinemachine.enabled = !EventSystem.current.IsPointerOverGameObject(); 
    }

}


