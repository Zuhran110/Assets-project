using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [Header("Movement Settings")]
    public Transform player; // Reference to the player’s Transform

    public float moveSpeed = 2f; // Speed of movement towards the player

    [Header("Score Settings")]
    public int scoreValue = 10; // Points awarded upon destruction

    private void Start()
    {
        // Optionally find the player dynamically
        if (player == null && GameObject.FindGameObjectWithTag("player") != null)
        {
            player = GameObject.FindGameObjectWithTag("player").transform;
        }
    }

    private void Update()
    {
        FollowPlayer();
    }

    private void FollowPlayer()
    {
        if (player != null)
        {
            Vector3 direction = (player.position - transform.position).normalized;
            transform.position += direction * moveSpeed * Time.deltaTime;
        }
    }

    private void OnDestroy()
    {
        if (ScoreManager.Instance != null)
        {
            ScoreManager.Instance.AddScore(scoreValue);
        }
    }
}