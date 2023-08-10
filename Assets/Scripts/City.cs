using System.Collections;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Threading;
using UnityEngine;

public class City : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rigidbody2d;
    public Vector2 speed = new Vector2(3f,0f);
    public bool Duplicator = false;
    
    void Start()
    {
        if (Duplicator)
        {
            rigidbody2d = GetComponent<Rigidbody2D>();
            rigidbody2d.velocity += speed;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < -30.0f)
        {
            Destroy(gameObject);
        }

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        FlyControl flyControl = other.GetComponent<FlyControl>(); 
        

        if (flyControl != null)
        {
            flyControl.ControlAble = false;
            flyControl.Died();
            
        }
    }
}
