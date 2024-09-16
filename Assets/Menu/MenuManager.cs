using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public GameObject menu;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(menu.gameObject.activeSelf == false) {
                menu.gameObject.SetActive(!menu.gameObject.activeSelf);
                Time.timeScale = 0;
            } else {
                menu.gameObject.SetActive(!menu.gameObject.activeSelf);
                Time.timeScale = 1;
            }
        }
    }
}
