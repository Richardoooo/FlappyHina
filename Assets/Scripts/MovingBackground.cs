using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class MovingBackground : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Ground;
    Vector2 InitialPosition = new Vector2(20f,-3.94f);
    bool IsDuplicated = false;
    Vector3 Speed = new Vector3(-0.08f, 0f, 0f);
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < 0.05f && !IsDuplicated)
        {
            Duplicate();
            IsDuplicated = true;
        }

        if (transform.position.x < -20f)
        {
            Destroy(gameObject);
        }
        
    }
    void Duplicate()
    {
        GameObject CityObject = Instantiate(Ground, InitialPosition, Quaternion.identity);
    }

    private void FixedUpdate()
    {
        transform.position += Speed;
    }
}
