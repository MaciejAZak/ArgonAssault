using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        Invoke("LoadGame", 2f);
    }

    void LoadGame()
    {
        SceneManager.LoadScene(1);
    }
}

