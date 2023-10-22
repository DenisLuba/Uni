using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButtonScript : MonoBehaviour
{
    public string loadScene = "";

    public void onClick()
    {
        SceneManager.LoadScene(loadScene, LoadSceneMode.Single);
    }
}
