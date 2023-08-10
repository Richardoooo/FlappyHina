using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyControl : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rigidbody2d;
    AudioSource audioSource;
    public AudioClip WingClip;
    public List<float> AngleVelocity = new List<float>()
    {
       100f,
       -100f,
    };
    Vector2 Speed = new Vector2(0f,3f);

    bool IsCountDown = false;
    public float CountTime = 10f;

    public static float Distance = 0f;

    public bool ControlAble = true;

    float Record;

    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
        Record = PlayerPrefs.GetFloat("LongestDistance", 0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) && ControlAble)
        {
            if (rigidbody2d.velocity.y < 2f)
                rigidbody2d.velocity = Speed;
            else if (rigidbody2d.velocity.y > 5f)
            {
                
            }
            else
            {
                rigidbody2d.velocity += new Vector2(0f, 2.0f);
            }
            audioSource.PlayOneShot(WingClip);

        }

        if (rigidbody2d.velocity.y > 0f)
        {
            rigidbody2d.gravityScale = 0.6f;
        }
        else
        {
            rigidbody2d.gravityScale = 1.2f;
        }

        if (IsCountDown)
        {
            CountTime -= Time.deltaTime;
            if (CountTime < 0f)
            {
                GameOverMenu.instance.GameOver();
                IsCountDown = false;
            }
        }
    }

    void FixedUpdate()
    {
        Distance += 0.05f;
        Meter.SetValue(Distance.ToString("#0.0"));
    }
    public void Died()
    {
        IsCountDown = true;
        Meter.IsDied = true;
        rigidbody2d.velocity = new Vector2(-3f, 1f);
        rigidbody2d.angularVelocity = AngleVelocity[Random.Range(0,2)] + Random.Range(-40f,40f);
        if (Record < Distance)
        {
            PlayerPrefs.SetFloat("LongestDistance", Distance);
        }

    }
}
