using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Robot : MonoBehaviour,IEnemy
{
     public void Attack(){
        Debug.Log("Robot greift an!");
    }
      public void Explode(){
        Debug.Log("Robot greift an!");
    }
      public void Move(){
        Debug.Log("Robot greift an!");
    }
}
