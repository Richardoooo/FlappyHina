using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameOverMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject GameOverImage;
    public GameObject RetartButton;
    public TextMeshProUGUI RecordText;
    public TextMeshProUGUI PresentDistance;
    public AudioSource InitialAudio;
    public AudioSource FinalAudio;
    public static GameOverMenu instance { get; private set; }
    float Rank;
    string Distance;
    void Start()
    {
        //RecordText.text = string.Empty;
        //PresentDistance.text = string.Empty;
    }
    void Awake()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GameOver()
    {
        Rank = PlayerPrefs.GetFloat("LongestDistance", 0f);
        Distance = Meter.Result;
        RecordText.text = "Record: " + Rank.ToString("#0.0") + "M";
        PresentDistance.text = "You fly: " + Distance + "M";
        GameOverImage.SetActive(true);
        RetartButton.SetActive(true);
        InitialAudio.Stop();
        FinalAudio.Play();
        
        Time.timeScale = 0;
    }    
}
