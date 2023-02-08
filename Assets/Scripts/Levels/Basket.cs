using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Basket : MonoBehaviour
{
    public GameObject levelComplited;
    public string nextLevelName;

    private void Start()
    {
        levelComplited.SetActive(false);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Debug.Log("Pi³ka w koszu");
            levelComplited.SetActive(true);
            Invoke("LoadNewLevel", 3f);
            
        }
    }


    void LoadNewLevel()
    {
        SceneManager.LoadScene(nextLevelName);
        
    }
}
