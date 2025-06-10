using UnityEngine;

public class TamponProjectile : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Mirror"))
        {
            Debug.Log("Game Over!");
        }
        else
        {
            Debug.Log("Hit: " + collision.gameObject.name);
        }

        Destroy(gameObject);
    }
}