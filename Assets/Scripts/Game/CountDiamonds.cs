using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDiamonds : MonoBehaviour
{
    private Text txt;

    void Start()
    {
        txt = GetComponent<Text>();
        txt.text = PlayerPrefs.GetInt("Diamonds").ToString();
    }

   
  
}
