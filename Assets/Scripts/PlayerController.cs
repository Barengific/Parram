using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerController : MonoBehaviour
{

    private Rigidbody2D rb;
    private float speeder = 3f;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnMove(InputValue value)
    {
        rb.velocity = value.Get<Vector2>() * speeder;
    }


    public float speed = 5.0f; // speed of player movement
    private Vector3 targetPosition; // position of touch on screen

    // Update is called once per frame
    void Update()
    {
        // check if there is a touch on the screen
        if (Input.touchCount > 0)
        {
            // get the position of the touch on the screen
            targetPosition = Camera.main.ScreenToWorldPoint(Input.touches[0].position);
            targetPosition.z = 0; // set z position to 0 for 2D game

            // calculate the direction from current position to target position
            Vector3 direction = (targetPosition - transform.position).normalized;

            // move the player towards the target position
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
        }
    }

}
