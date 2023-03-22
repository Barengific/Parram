using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGeneration : MonoBehaviour
{
    public GameObject Tile1;
    public GameObject Tile2;
    public GameObject StartTile;

    private float Index = 0;

    private void Start()
    {
        GameObject StartPlane1 = Instantiate(StartTile, transform);
        StartPlane1.transform.position = new Vector2(0, 7);
        StartPlane1.AddComponent<BoxCollider2D>();


        GameObject StartPlane2 = Instantiate(StartTile, transform);
        StartPlane2.transform.position = new Vector2(0, -1);
        StartPlane2.AddComponent<BoxCollider2D>();

        GameObject StartPlane3 = Instantiate(StartTile, transform);
        StartPlane3.transform.position = new Vector2(0, -9);
        StartPlane3.AddComponent<BoxCollider2D>();    

        GameObject StartPlane4 = Instantiate(StartTile, transform);
        StartPlane4.transform.position = new Vector2(0, -17);
        StartPlane4.AddComponent<BoxCollider2D>();

        GameObject StartPlane5 = Instantiate(StartTile, transform);
        StartPlane5.transform.position = new Vector2(0, -25);
        StartPlane5.AddComponent<BoxCollider2D>();

    }

    private void Update()
    {
        gameObject.transform.position += new Vector3(0, 4 * Time.deltaTime, 0);

        if (transform.position.y >= Index)
        {
            int RandomInt1 = Random.Range(0, 2);

            if (RandomInt1 == 1)
            {
                int rndX = Random.Range(-5, 5);
                GameObject TempTile1 = Instantiate(Tile1, transform);
                TempTile1.AddComponent<BoxCollider2D>();
                TempTile1.transform.position = new Vector2(rndX, -16);
            }
            else if (RandomInt1 == 0)
            {
                int rndX = Random.Range(-5, 5);
                GameObject TempTile1 = Instantiate(Tile2, transform);
                TempTile1.AddComponent<BoxCollider2D>();
                TempTile1.transform.position = new Vector2(rndX, -16);
            }

            int RandomInt2 = Random.Range(0, 2);

            if (RandomInt2 == 1)
            {
                int rndX = Random.Range(-5, 5);
                GameObject TempTile2 = Instantiate(Tile1, transform);
                TempTile2.AddComponent<BoxCollider2D>();
                TempTile2.transform.position = new Vector2(rndX, -24);
            }
            else if (RandomInt2 == 0)
            {
                int rndX = Random.Range(-5, 5);
                GameObject TempTile2 = Instantiate(Tile2, transform);
                TempTile2.AddComponent<BoxCollider2D>();
                TempTile2.transform.position = new Vector2(rndX, -24);
            }

            Index = Index + 15.95f;
        }
    }
}
