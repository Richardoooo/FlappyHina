using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject RestartImage;
    void Start()
    {
        //RestartImage.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RestartGame()
    {
        Time.timeScale = 1;
        Meter.IsDied = false;
        SceneManager.LoadScene("GameScene", LoadSceneMode.Single);
    }
}
