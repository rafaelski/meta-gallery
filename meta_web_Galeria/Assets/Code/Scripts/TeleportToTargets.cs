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

        var temp1 = target.transform.eulerAngles.y;
        //var temp = GetRotationLikeInspector(target.transform.eulerAngles.y);

        print(temp1);
        //print(temp);

        //rotation
        //vcam.GetCinemachineComponent<CinemachinePOV>().m_HorizontalAxis.Value = GetRotationLikeInspector(target.transform.eulerAngles.y);
        //vcam.GetCinemachineComponent<CinemachinePOV>().m_VerticalAxis.Value = GetRotationLikeInspector(target.transform.eulerAngles.x);
        vcam.GetCinemachineComponent<CinemachinePOV>().m_HorizontalAxis.Value = target.transform.eulerAngles.y;
        vcam.GetCinemachineComponent<CinemachinePOV>().m_VerticalAxis.Value = target.transform.eulerAngles.x;
    }

    public static float GetRotationLikeInspector(float eulerAngles)
    {
        //float result = eulerAngles - Mathf.CeilToInt(eulerAngles / 360f) * 360f;
        float result = eulerAngles - 360f;

        //if (eulerAngles < 0)
        //{
        //    result = eulerAngles - 360f;
        //}
        //else
        //{
        //    result = eulerAngles;
        //}

        return result;
    }
}

