using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenURL : MonoBehaviour
{

    public void OpenCustomURL(string url)
    {
        Application.OpenURL("https://www." + url);
    }

}
