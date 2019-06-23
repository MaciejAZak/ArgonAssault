using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelLoader : MonoBehaviour {

    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
    // Use this for initialization
    void Start () {
        Invoke("LoadGame", 2f);
    }
	
void LoadGame()
    {
        SceneManager.LoadScene(1);
    }
}
