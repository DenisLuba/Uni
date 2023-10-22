using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OutOfGame : MonoBehaviour
{

    public string loadScene = "";

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name.Equals("Player"))
        {
            Destroy(other.gameObject);
            SceneManager.LoadScene(loadScene, LoadSceneMode.Single);
        }
    }
}
