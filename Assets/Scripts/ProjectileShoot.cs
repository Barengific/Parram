using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileShoot : MonoBehaviour
{

    public Transform shootingPoint;
    public GameObject projectilePrefab;

    private int counter = 0;

    float yet;
    const float interval = 5.0f;

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
        }

        yet += Time.deltaTime;

        if (yet >= interval)
        {
            yet -= interval;

            Instantiate(projectilePrefab, shootingPoint.position, transform.rotation);

        }



    }
}
