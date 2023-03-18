using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneStart : MonoBehaviour
{

    public void Scene1()
    {
        SceneManager.LoadScene("PlayScene");
    }
}
