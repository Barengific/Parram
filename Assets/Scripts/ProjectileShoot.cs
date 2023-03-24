using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileShoot : MonoBehaviour
{

    public Transform shootingPointUp;
    public Transform shootingPointDown;
    public Transform shootingPointRight;
    public Transform shootingPointLeft;

    public GameObject projectilePrefab;

    private int counter = 0;

    float yet1;
    float yet2;
    float yet3;
    float yet4;


    const float interval = 5.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        ProjectileBasicUp();
        ProjectileBasicDown();
        ProjectileBasicRight();
        ProjectileBasicLeft();

    }

    void ProjectileBasicUp()
    {

        yet1 += Time.deltaTime;

        if (yet1 >= interval)
        {
            yet1 -= interval;

            Instantiate(projectilePrefab, shootingPointUp.position, shootingPointUp.transform.rotation);

        }

    }

    void ProjectileBasicDown()
    {
        yet2 += Time.deltaTime;

        if (yet2 >= interval)
        {
            yet2 -= interval;

            Instantiate(projectilePrefab, shootingPointDown.position, shootingPointDown.transform.rotation);

        }

    }

    void ProjectileBasicRight()
    {
        yet3 += Time.deltaTime;

        if (yet3 >= interval)
        {
            yet3 -= interval;

            Instantiate(projectilePrefab, shootingPointRight.position, shootingPointRight.transform.rotation);

        }

    }


    void ProjectileBasicLeft()
    {
        yet4 += Time.deltaTime;

        if (yet4 >= interval)
        {
            yet4 -= interval;

            Instantiate(projectilePrefab, shootingPointLeft.position, shootingPointLeft.transform.rotation);

        }

    }
}
