using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] private float attackCooldown; // Cooldown between attacks
    [SerializeField] private Transform firePoint; // Point from where fireballs spawn
    [SerializeField] private BulletPooler bulletPooler; // Reference to the BulletPooler

    private float cooldownTimer = Mathf.Infinity;

    private void Update()
    {
        // Handle attack input and cooldown
        if (Input.GetMouseButton(0) && cooldownTimer > attackCooldown)
            Attack();

        // Update cooldown timer
        cooldownTimer += Time.deltaTime;
    }

    private void Attack()
    {
        cooldownTimer = 0;

        // Get a bullet from the pool
        GameObject bullet = bulletPooler.GetBullet();
        bullet.transform.position = firePoint.position;

        // Set the direction of the bullet (assumed to be moving right)
        bullet.GetComponent<Projectile1>().SetDirection(1); // 1 for right
    }
}