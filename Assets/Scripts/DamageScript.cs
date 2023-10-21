using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageScript : MonoBehaviour
{
    public int damage = 10;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
            var player = collision.gameObject.GetComponent<Player>();
            player.LifeUpdate(damage);
        }
        
    }
}
