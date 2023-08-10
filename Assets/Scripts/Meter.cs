using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Meter : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI textComponent;
    public string DisplayUnit = " M";
    public static bool IsDied = false;
    public static string Result = "";
    public static void SetValue(string Value)
    {
        if (!IsDied)
        {
            Result = Value;
        }
    }

    private void FixedUpdate()
    {
        if (!IsDied)
        {
            textComponent.text = Result + DisplayUnit;
        }
    }

}
