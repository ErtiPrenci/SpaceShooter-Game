using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
     public EnemyFactory enemyFactory; 
      public float spawnSpeed = 4.0f;
    public float spawnSpeedInc = 20.0f;
     
     void Start() { 
                  StartCoroutine(CreateEnemies());

        } 
        void SpawnEnemies() {
             IEnemy zombie = enemyFactory.SpawnEnemy("Zombie");
              zombie.Attack(); 
           //   IEnemy robot = enemyFactory.SpawnEnemy("Robot"); 
           //   robot.Attack();
             } 
              IEnumerator CreateEnemies()
    {
        while (true)
        {
            if (Time.time >= spawnSpeedInc)
            {
                if (spawnSpeed > 1.0f)
                {
                    spawnSpeed -= 1.0f;
                    spawnSpeedInc += 10.0f;
                }
                else
                {
                    spawnSpeed = 1.0f;
                }
            }

            SpawnEnemies();
            yield return new WaitForSeconds(spawnSpeed);           
        }
    }
        }