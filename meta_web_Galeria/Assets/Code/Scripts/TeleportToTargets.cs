using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;


public class TeleportToTargets : MonoBehaviour
{

    public Player player;
    public CinemachineVirtualCamera vcam;
    [SerializeField] private Transform initialPosition;

    private void Awake()
    {
        Teleport(initialPosition);
    }


    public void Teleport(Transform target)
    {
        // position
        player.transform.position = target.position;

        //rotation
        vcam.GetCinemachineComponent<CinemachinePOV>().m_HorizontalAxis.Value = target.transform.eulerAngles.y;
        vcam.GetCinemachineComponent<CinemachinePOV>().m_VerticalAxis.Value = target.transform.eulerAngles.x;
    }


    public static float GetRotationLikeInspector(float eulerAngles)
    {
        float result = eulerAngles - 360f;
        return result;
    }
}

