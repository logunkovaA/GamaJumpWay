using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopBG : MonoBehaviour
{
private bool activeLose, activePlayTxt;
   public GameObject detectClicks, allCubes, playTxt, loseBtns;

    void OnEnable()
    {
    if(playTxt.activeSelf){
    activePlayTxt=true;
    playTxt.SetActive (false);
	}
        
        detectClicks.GetComponent <BoxCollider> ().enabled = false;
        allCubes.SetActive (true);
        if (loseBtns.activeSelf){
        activeLose=true;
            loseBtns.SetActive(false);
		}
    
    }

    void OnDisable () {

    if(activeLose)
    loseBtns.SetActive(true);
    if(activePlayTxt)
    playTxt.SetActive(true);
     detectClicks.GetComponent <BoxCollider> ().enabled = true;
             allCubes.SetActive (false);

	}
    
}
