using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hideMenu : MonoBehaviour
{
    void Start()
    {
        this.gameObject.SetActive(!this.gameObject.activeSelf);
    }
}
