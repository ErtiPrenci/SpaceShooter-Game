using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonStart : MonoBehaviour
{
    void Start()
    {
        Button button = gameObject.GetComponent<Button>();
        if (button != null) {
           button.onClick.AddListener(() => {
               SceneManager.SingletonSceneManager.LoadScene("SampleScene");
           }); 
        } else { 
           Debug.LogError("BtnStartGame script is not attached to an object with a Button component."); 
        }
    }
}
