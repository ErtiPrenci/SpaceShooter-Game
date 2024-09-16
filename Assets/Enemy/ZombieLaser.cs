using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieLaser : MonoBehaviour
{
         public float _speed = 8.0f;
    public float maxx = -6.0f;
    // Start is called before the first frame update
    void Start()
    {
        transform.Rotate(0.0f,0.0f, 180.0f);
    }

    // Update is called once per frame
    void Update()
    {
         transform.Translate(Vector2.up * (_speed * Time.deltaTime));
        if (transform.position.y < maxx)
        {
            Destroy(this.gameObject);
        }
    }
}
