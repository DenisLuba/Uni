using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenWall : MonoBehaviour
{

    private Animator wallAnimator;

    void Start()
    {
        wallAnimator = GameObject.Find("Wall").GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Equals("Player"))
        {
            wallAnimator.SetBool("StartWallAnim1", true);
        }
    }
}
