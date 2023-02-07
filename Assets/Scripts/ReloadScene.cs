using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadScene : MonoBehaviour
{
    private void OnMouseUp()
    {
        SceneManager.LoadScene(Application.loadedLevelName);
    }
}
