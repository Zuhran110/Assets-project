using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    private float startPos, length;
    public float scrollSpeed = 2f; // Speed of horizontal scrolling

    private void Start()
    {
        // Get the initial position and the width of the background
        startPos = transform.position.x;
        length = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    private void FixedUpdate()
    {
        // Move the background horizontally to the left
        transform.position += Vector3.left * scrollSpeed * Time.deltaTime;

        // Reset the position for seamless looping
        if (transform.position.x <= startPos - length)
        {
            transform.position = new Vector3(startPos, transform.position.y, transform.position.z);
        }
    }
}