using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuMoveAnimation : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 FinalPosition = new Vector3 (-4.8f , 0f, 0f);
    Vector2 InitialPosition = new Vector2 (-7f , -3f);
    bool IsMoving = false;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveHina()
    {
        IsMoving = true;
    }
    void FixedUpdate()
    {
        if (IsMoving)
        {
            transform.position = FinalPosition / 50 - transform.position / 50 + transform.position;
            Debug.Log(transform.position);
        }
        if (Mathf.Round(transform.position.x * 10f) / 10f == Mathf.Round(FinalPosition.x * 10f) / 10f)
        {
            GameStart.instance.StartGame();
        }
    }
}
