using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeItem : MonoBehaviour
{
    public int addLife = 10;

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.name.Equals("Player"))
        {
            var player = collision.gameObject.GetComponent<Player>();
            player.LifeUpdate(addLife);
            Destroy(gameObject);
        }
    }

    private void OnDestroy()
    {
        print("Item destroyed");
    }
}
