using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
    public int scene = 1;

   public void btnPlay()
    {

        SceneManager.LoadScene(scene);

    }
}
