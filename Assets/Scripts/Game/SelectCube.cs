using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectCube : MonoBehaviour
{
[HideInInspector]
public string nowCube;
public GameObject selectCube, buyCube,mainCube;


void Start (){
    if (PlayerPrefs.GetString("Cube") !="Open")
    PlayerPrefs.SetString("Cube","Open");


}

    void OnTriggerEnter (Collider other){
    nowCube=other.gameObject.name;
     other.transform.localScale += new Vector3 (0.2f, 0.2f, 0.2f);
     if(PlayerPrefs.GetString (other.gameObject.name)=="Open"){
          selectCube.SetActive(true);
          buyCube.SetActive(false);
     }else
     {
     selectCube.SetActive(false);
          buyCube.SetActive(true);
	 }

	}

      void OnTriggerExit (Collider other){
     other.transform.localScale -= new Vector3 (0.2f, 0.2f, 0.2f);
	}
}
