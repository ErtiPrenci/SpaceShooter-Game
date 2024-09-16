using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFactory : MonoBehaviour {
     public GameObject zombiePrefab; 
// Zuweisen im Unity-Editor 
public GameObject robotPrefab; // Zuweisen im Unity-Editor 
 public IEnemy SpawnEnemy(string enemyType) 
    {
        GameObject enemiesobj = null; 
        switch (enemyType) 
        { 
            case "Zombie":
                enemiesobj = Instantiate(zombiePrefab, transform.position + new Vector3(Random.Range(-10.0f, 10.0f), 6.0f, 0), Quaternion.identity);
                break; 
            case "Robot": 
                enemiesobj = Instantiate(robotPrefab, transform.position + new Vector3(Random.Range(-10.0f, 10.0f), 6.0f, 0), Quaternion.identity); 
                break; 
            default: 
                Debug.LogError("Unbekannter Gegnertyp: " + enemyType); 
                return null; 
        } 
        
        return enemiesobj.GetComponent<IEnemy>(); 
    } 
    }