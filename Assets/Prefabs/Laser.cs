using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
        public Collider2D enemyObject;

    public float _speed = 8.0f;
    public float maxy = 7.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * (_speed * Time.deltaTime));
        if (transform.position.y > maxy)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Zombie"))
        {
            Destroy(this.gameObject);
        }
    }
}
