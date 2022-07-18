using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;


public class GameManager : MonoBehaviour
{
    private int levelID = 0;
    private AsyncOperationHandle m_SceneHandle;
    private PlayerInputActions playerInputActions;


    private void Awake()
    {
        playerInputActions = new PlayerInputActions();
        playerInputActions.UI.Enable();
    }


    private void Update()
    {
        if (playerInputActions.UI.tecla_1.WasPerformedThisFrame())
        {
            NextLevel(0);
        }

        if (playerInputActions.UI.tecla_2.WasPerformedThisFrame())
        {
            NextLevel(0);
        }
    }


    private void NextLevel(int lvl)
    {
        levelID = lvl;
        m_SceneHandle = Addressables.DownloadDependenciesAsync("Cena_" + lvl);
        m_SceneHandle.Completed += M_SceneHandle_Completed;
    }


    private void M_SceneHandle_Completed(AsyncOperationHandle obj)
    {
        if (obj.Status == AsyncOperationStatus.Succeeded)
        {
            Addressables.LoadSceneAsync("Cena_" + levelID, UnityEngine.SceneManagement.LoadSceneMode.Single, true);
        }
    }

}




