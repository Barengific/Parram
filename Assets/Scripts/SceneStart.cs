using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneStart : MonoBehaviour
{

    public void ScenePlay()
    {
        SceneManager.LoadScene("PlayScene");
    }

    public void SceneShop()
    {
        SceneManager.LoadScene("ShopScene");
    }

    public void SceneHome()
    {
        SceneManager.LoadScene("MenuScene");
    }

    public void SceneSetting()
    {
        SceneManager.LoadScene("SettingScene");
    }
}
