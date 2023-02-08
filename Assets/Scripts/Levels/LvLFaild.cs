using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LvLFaild : MonoBehaviour
{
    public GameObject faild;
    public string nextLevelName;

    private void Start()
    {
        faild.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            faild.SetActive(true);
            Invoke("LoadNewLevel", 3f);
        }
    }

    void LoadNewLevel()
    {
        SceneManager.LoadScene(nextLevelName);
    }
}
