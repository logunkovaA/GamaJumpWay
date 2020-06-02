using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectDiamonds : MonoBehaviour
{
    public Text diamonds;
   void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Diamond")
        {
            Destroy(other.gameObject);
            PlayerPrefs.SetInt("Diamonds", PlayerPrefs.GetInt("Diamonds")+1);
            diamonds.text = PlayerPrefs.GetInt("Diamonds").ToString();
        }
    }
}
