using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Projectile : MonoBehaviour
{

    public float speed;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.up * speed;


    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    //void OnCollisionEnter(Collision collision)
    //{
    //    // Check if the collided object has the tag "Player"
    //    if (collision.gameObject.CompareTag("Player"))
    //    {
    //        // Do something when the collision happens
    //        Debug.Log("Collision detected!");
    //        SceneManager.LoadScene("MenuScene");
    //    }
    //}
}
