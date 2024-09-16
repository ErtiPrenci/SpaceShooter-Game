using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject laser;
     public Rigidbody2D playerShip;
     public Collider2D enemyLaser;


    public GameObject explosionAnimation;

    [SerializeField] private float _speed = 4.0f;
    [SerializeField] private float _boundaryX = 17.0f; // Adjust this according to your scene
    [SerializeField] private float _boundaryY = 5.0f; // Adjust this according to your scene
    [SerializeField] private float fireRate = 5;
     [SerializeField] private float nextFireTime = 0;  

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moveDirection = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
        {
            moveDirection += transform.up;
        }
        if (Input.GetKey(KeyCode.S))
        {
            moveDirection += -transform.up;
        }
        if (Input.GetKey(KeyCode.A))
        {
            moveDirection += -transform.right;
        }
        if (Input.GetKey(KeyCode.D))
        {
            moveDirection += transform.right;
        }

        if (moveDirection.magnitude > 0)
        {
            transform.Translate(moveDirection.normalized * (_speed * Time.deltaTime));

            float clampedX = Mathf.Clamp(transform.position.x, -_boundaryX, _boundaryX);
            float clampedY = Mathf.Clamp(transform.position.y, -_boundaryY, _boundaryY);

            transform.position = new Vector3(clampedX, clampedY, transform.position.z);
        }
    

                  if(Input.GetKeyDown(KeyCode.Space)){
                    if(Time.time >= nextFireTime){
                        Instantiate(laser,new Vector2(transform.position.x,transform.position.y + 0.5f),Quaternion.identity);
                        nextFireTime += Time.time -nextFireTime +fireRate; 
                    }
    }
}
  private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("LaserEnemy") || other.CompareTag("Zombie"))
        {
            Instantiate(explosionAnimation, transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
}
