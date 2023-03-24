using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGeneration : MonoBehaviour
{
    public GameObject Tile1;
    public GameObject Tile2;
    public GameObject StartTile;

    float totalPlayTime;
    float maxIntervalTime = 4f;
    float timeSinceLastSpawn;

    public float ObstacleVelocity = 2f;

    private void Update()
    {
        totalPlayTime += Time.deltaTime;

        if (totalPlayTime > 10.0f)
        {
            maxIntervalTime = 4f;
        }
        if (totalPlayTime > 20.0f)
        {
            maxIntervalTime = 3f;
        }
        if (totalPlayTime > 30.0f)
        {
            maxIntervalTime = 2f;
        }
        if (totalPlayTime > 40.0f)
        {
            maxIntervalTime = 1f;
        }
        if (totalPlayTime > 50.0f)
        {
            maxIntervalTime = 0.5f;
        }

        timeSinceLastSpawn += Time.deltaTime;
        if (timeSinceLastSpawn > maxIntervalTime)
        {
            int RandomInt1 = Random.Range(0, 2);

            if (RandomInt1 == 1)
            {
                int rndX = Random.Range(-5, 5);
                GameObject TempTile1 = Instantiate(Tile1, transform);
                TempTile1.AddComponent<BoxCollider2D>();
                Rigidbody2D obstacleRigidbody = TempTile1.GetComponent<Rigidbody2D>();
                obstacleRigidbody.velocity = new Vector2(0, ObstacleVelocity);
                TempTile1.transform.position = new Vector2(rndX, -16);
            }
            else if (RandomInt1 == 0)
            {
                int rndX = Random.Range(-5, 5);
                GameObject TempTile1 = Instantiate(Tile2, transform);
                TempTile1.AddComponent<BoxCollider2D>();
                Rigidbody2D obstacleRigidbody = TempTile1.GetComponent<Rigidbody2D>();
                obstacleRigidbody.velocity = new Vector2(0, ObstacleVelocity);
                TempTile1.transform.position = new Vector2(rndX, -16);
            }

            int RandomInt2 = Random.Range(0, 2);

            if (RandomInt2 == 1)
            {
                int rndX = Random.Range(-5, 5);
                GameObject TempTile2 = Instantiate(Tile1, transform);
                TempTile2.AddComponent<BoxCollider2D>();
                Rigidbody2D obstacleRigidbody = TempTile2.GetComponent<Rigidbody2D>();
                obstacleRigidbody.velocity = new Vector2(0, ObstacleVelocity);
                TempTile2.transform.position = new Vector2(rndX, -24);
            }
            else if (RandomInt2 == 0)
            {
                int rndX = Random.Range(-5, 5);
                GameObject TempTile2 = Instantiate(Tile2, transform);
                TempTile2.AddComponent<BoxCollider2D>();
                Rigidbody2D obstacleRigidbody = TempTile2.GetComponent<Rigidbody2D>();
                obstacleRigidbody.velocity = new Vector2(0, ObstacleVelocity);
                TempTile2.transform.position = new Vector2(rndX, -24);
            }

            timeSinceLastSpawn = 0f;
        }
    }
}
