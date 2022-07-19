using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using Cinemachine;

public class FreeLookCameraUIController : MonoBehaviour
{

    [SerializeField] Cinemachine.CinemachineVirtualCamera virtualLookcamera;
    [SerializeField] CinemachineInputProvider cinemachine;


    void Update()
    {
        //virtualLookcamera.enabled = !EventSystem.current.IsPointerOverGameObject();
        cinemachine.enabled = !EventSystem.current.IsPointerOverGameObject(); 
    }

}


