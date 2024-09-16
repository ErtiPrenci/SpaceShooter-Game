using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour,IEnemy
{
      public float lowerBoundry = -5.5f;
    public float upperBoundry = 5.5f;
    public float speed = 5;


public GameObject ZombieLaser;
 public GameObject explosionAnimation;
     public Collider2D playerLaser;

   
       void Update() 
    {
        Move();
    }
    public void Attack(){
      StartCoroutine(shootZombieLaser());
    }
     public void Explode(){
    Instantiate(explosionAnimation, transform.position, Quaternion.identity);
        Destroy(this.gameObject);
            }
       public void Move()
    {
        transform.Translate(Vector2.down * (speed * Time.deltaTime));

        if (transform.position.y < lowerBoundry) 
        {
            transform.position = new Vector2(transform.position.x, upperBoundry);
        }
    }
     IEnumerator shootZombieLaser()
    {
        while(true)
        {
            createZombieLaser();
            yield return new WaitForSeconds(2.0f);
        }
    }
      void createZombieLaser()
    {
         if (transform.position.y < 4.5f) {
        Instantiate(ZombieLaser, transform.position + new Vector3(0, -0.8f, 0), Quaternion.identity);
         }
    }
       private void OnTriggerEnter2D(Collider2D other)
    { 
        if (other.CompareTag("Laser")) { 
            Explode(); 
        } 
    }
}


