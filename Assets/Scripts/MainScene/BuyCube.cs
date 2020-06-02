using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyCube : MonoBehaviour
{

public GameObject whichCube,selectBtn, mainCube;

/*void Start(){
    PlayerPrefs.SetInt ("Diamonds",500);
}*/

void OnMouseDown (){
    if(PlayerPrefs.GetInt("Diamonds")>=15){//buy cube
    PlayerPrefs.SetString(whichCube.GetComponent<SelectCube> ().nowCube,"Open");
    PlayerPrefs.SetString ("Now Cube",whichCube.GetComponent<SelectCube> ().nowCube);
    PlayerPrefs.SetInt("Diamonds",PlayerPrefs.GetInt("Diamonds")-15);
    mainCube.GetComponent<MeshRenderer>().material = GameObject.Find(whichCube.GetComponent<SelectCube> ().nowCube).GetComponent<MeshRenderer>().material;
    selectBtn.SetActive(true);
    gameObject.SetActive(false);
	}
}

     }
