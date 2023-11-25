using UnityEngine;

public class DamageScript : MonoBehaviour
{
    public int score = 10;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
            var player = collision.gameObject.GetComponent<Player>();
            player.LifeUpdate(-score);
        }
    }
}
