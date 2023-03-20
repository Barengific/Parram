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
        BoxCollider bc1 = StartPlane1.AddComponent<BoxCollider>();
        StartPlane1.transform.position = new Vector3(0, 7, 0);

        GameObject StartPlane2 = Instantiate(StartTile, transform);
        StartPlane2.transform.position = new Vector3(0, -1, 0);
        BoxCollider bc2 = StartPlane2.AddComponent<BoxCollider>();

        GameObject StartPlane3 = Instantiate(StartTile, transform);
        StartPlane3.transform.position = new Vector3(0, -9, 0);
        BoxCollider bc3 = StartPlane3.AddComponent<BoxCollider>();

        GameObject StartPlane4 = Instantiate(StartTile, transform);
        StartPlane4.transform.position = new Vector3(0, -17, 0);
        BoxCollider bc4 = StartPlane4.AddComponent<BoxCollider>();

        GameObject StartPlane5 = Instantiate(StartTile, transform);
        StartPlane5.transform.position = new Vector3(0, -25, 0);
        BoxCollider bc5 = StartPlane5.AddComponent<BoxCollider>();

    }

    private void Update()
    {
        gameObject.transform.position += new Vector3(0, 4 * Time.deltaTime, 0);

        if (transform.position.y >= Index)
        {
            int RandomInt1 = Random.Range(0, 2);

            if (RandomInt1 == 1)
            {
                GameObject TempTile1 = Instantiate(Tile1, transform);
                BoxCollider bc1 = TempTile1.AddComponent<BoxCollider>();
                TempTile1.transform.position = new Vector3(0, -16, 0);
            }
            else if (RandomInt1 == 0)
            {
                GameObject TempTile1 = Instantiate(Tile2, transform);
                BoxCollider bc2 = TempTile1.AddComponent<BoxCollider>();
                TempTile1.transform.position = new Vector3(0, -16, 0);
            }

            int RandomInt2 = Random.Range(0, 2);

            if (RandomInt2 == 1)
            {
                GameObject TempTile2 = Instantiate(Tile1, transform);
                BoxCollider bc1 = TempTile2.AddComponent<BoxCollider>();
                TempTile2.transform.position = new Vector3(0, -24, 0);
            }
            else if (RandomInt2 == 0)
            {
                GameObject TempTile2 = Instantiate(Tile2, transform);
                BoxCollider bc2 = TempTile2.AddComponent<BoxCollider>();
                TempTile2.transform.position = new Vector3(0, -24, 0);
            }

            Index = Index + 15.95f;
        }
    }
}
