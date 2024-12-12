using System.Collections;
using UnityEngine;

public class Health1 : MonoBehaviour
{
    [Header("Health")]
    [SerializeField] private float startingHealth;

    public float currentHealth { get; private set; }
    private bool dead;

    [Header("iFrames")]
    [SerializeField] private float iFramesDuration;

    [SerializeField] private int numberOfFlashes;
    private SpriteRenderer spriteRend;

    [Header("Components")]
    [SerializeField] private Behaviour[] components;

    private bool invulnerable;

    private void Awake()
    {
        currentHealth = startingHealth;
        spriteRend = GetComponent<SpriteRenderer>();
    }

    public void TakeDamage(float damage)
    {
        if (invulnerable || dead) return;

        currentHealth = Mathf.Clamp(currentHealth - damage, 0, startingHealth);

        if (currentHealth > 0)
        {
            StartCoroutine(Invulnerability());
        }
        else if (!dead)
        {
            dead = true;

            // Deactivate components and destroy GameObject
            foreach (Behaviour component in components)
                component.enabled = false;

            Destroy(gameObject);
        }
    }

    public void AddHealth(float value)
    {
        currentHealth = Mathf.Clamp(currentHealth + value, 0, startingHealth);
    }

    private IEnumerator Invulnerability()
    {
        invulnerable = true;
        Physics2D.IgnoreLayerCollision(10, 11, true);

        for (int i = 0; i < numberOfFlashes; i++)
        {
            spriteRend.color = new Color(1, 0, 0, 0.5f); // Flash red
            yield return new WaitForSeconds(iFramesDuration / (numberOfFlashes * 2));
            spriteRend.color = Color.white; // Reset to white
            yield return new WaitForSeconds(iFramesDuration / (numberOfFlashes * 2));
        }

        Physics2D.IgnoreLayerCollision(10, 11, false);
        invulnerable = false;
    }
}