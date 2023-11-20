using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpItem : MonoBehaviour
{
    private GameObject JumpButton;

    void Start()
    {
        JumpButton = GameObject.Find("JumpButton");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Equals("Player"))
        {
            JumpButton.SetActive(true);
            Destroy(gameObject);
        }
    }
}
