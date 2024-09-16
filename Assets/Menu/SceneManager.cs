using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour
{
    public static SceneManager SingletonSceneManager
    {
        get;
        private set;
    }

    private void Awake()
    {
        if (SingletonSceneManager == null)
        {
            SingletonSceneManager = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (SingletonSceneManager != this)
        {
            Destroy(gameObject);
        }
    }

    public void LoadScene(string sceneName) {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
    }
}
