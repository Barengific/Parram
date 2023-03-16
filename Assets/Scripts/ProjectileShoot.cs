using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileShoot : MonoBehaviour
{

    public Transform shootingPoint;
    public GameObject projectilePrefab;

    private int counter = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        counter++;
        if (counter == 1000)
        {
            
            counter = 0; // reset the counter variable to 0
            Instantiate(projectilePrefab, shootingPoint.position, transform.rotation);
        }



    }
}
