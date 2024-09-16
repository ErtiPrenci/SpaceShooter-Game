using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class restartGame : MonoBehaviour
{
    void Start()
    {
        Button button = gameObject.GetComponent<Button>();
        if (button != null) {
           button.onClick.AddListener(() => {
                Time.timeScale = 1;
                SceneManager.SingletonSceneManager.LoadScene("SampleScene");
           }); 
        } else { 
           Debug.LogError("restartGame script is not attached to an object with a Button component."); 
        }
    }
}