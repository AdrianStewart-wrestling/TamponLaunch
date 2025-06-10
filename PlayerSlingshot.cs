using UnityEngine;

public class PlayerSlingshot : MonoBehaviour
{
    public GameObject tamponPrefab;
    public Transform launchPoint;
    public float launchForce = 700f;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject tampon = Instantiate(tamponPrefab, launchPoint.position, Quaternion.identity);
            Rigidbody2D rb = tampon.GetComponent<Rigidbody2D>();
            Vector2 direction = (Camera.main.ScreenToWorldPoint(Input.mousePosition) - launchPoint.position);
            rb.AddForce(direction.normalized * launchForce);
        }
    }
}