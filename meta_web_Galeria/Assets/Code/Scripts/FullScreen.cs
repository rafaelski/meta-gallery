using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullScreen : MonoBehaviour
{
    // Start is called before the first frame update
    void OnEnable()
    {
        Screen.fullScreen = !Screen.fullScreen;
    }

}
