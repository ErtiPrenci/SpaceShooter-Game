using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonMenu : MonoBehaviour
{
    void Start()
    {
        // Get the Button component attached to this GameObject
        Button button = gameObject.GetComponent<Button>();
        if (button != null) {
           button.onClick.AddListener(() => {
                Time.timeScale = 1;
                // LoadScene from Singleton Class
                SceneManager.SingletonSceneManager.LoadScene("Menu");
           }); 
        } else { 
           Debug.LogError("buttonMenu script is not attached to an object with a Button component."); 
        }
    }
}
