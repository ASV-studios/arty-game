using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{    public void LoadHomeScene()
    {
        SceneManager.LoadScene("Home Scene");
    }

    public void LoadPlayerLobbyScene()
    {
        SceneManager.LoadScene("Player Lobby Scene");
    }

    public void LoadPlayScene()
    {
        SceneManager.LoadScene("Play Scene");
    }

}
