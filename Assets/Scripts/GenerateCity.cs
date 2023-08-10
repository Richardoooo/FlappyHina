using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GenerateCity : MonoBehaviour
{
    // Start is called before the first frame update
    Vector2 InitialPosition = new Vector2(12f,0f);
    public float WaitingInterval = 2.0f;
    public List<GameObject> CityPool;
    // Random Ra = new Random();
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (WaitingInterval < 0)
        {
            float PassPoint = Random.Range(-3f,4.5f);
            City(new Vector2(12f, PassPoint + PassInterval(FlyControl.Distance) + Random.Range(-0.5f, 0.5f) + 4.3f));
            City(new Vector2(12f, PassPoint - PassInterval(FlyControl.Distance) + Random.Range(-0.5f, 0.5f) - 4.3f));
            WaitingInterval = 2.0f + Random.Range(-0.5f, 0.5f);
        }
        WaitingInterval -= Time.deltaTime;
    }

    void City(Vector2 Position)
    {
        GameObject CityObject = Instantiate(CityPool[Random.Range(0,2)], Position, Quaternion.identity);
        City StartCity = CityObject.GetComponent<City>();
        StartCity.Duplicator = true;
    }

public float PassInterval(float Meter)
    {
        return (6 * Mathf.Log(0.2f * Meter + 2)) / (0.2f * Meter + 2);
    }
}
