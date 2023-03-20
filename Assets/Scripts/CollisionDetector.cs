using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CollisionDetector : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider cube)
    {
        Destroy(cube.gameObject);
        print("Another object has entered the trigger");
        Debug.Log("Collision detected!");
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
