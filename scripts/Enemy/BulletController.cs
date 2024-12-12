using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float bulletSpeed = 5f;    // Speed of the bullet
    public float lifeTime = 3f;      // How long the bullet exists before being destroyed

    private void Start()
    {
        // Destroy the bullet after its lifetime
        Destroy(gameObject, lifeTime);
    }

    private void Update()
    {
        // Move the bullet forward
        transform.Translate(Vector3.up * bulletSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Add collision logic here (e.g., damage the player)
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player hit!");
            // Other logic, like reducing player health
            Destroy(gameObject); // Destroy the bullet
        }
    }
}