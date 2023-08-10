using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickCollider : MonoBehaviour
{   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
