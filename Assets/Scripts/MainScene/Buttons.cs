using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public GameObject shopBG;
    public Sprite mus_on, mus_off;
    public float bigger = 1.1f, lower = 1f;

    void Start()
    {
        if (gameObject.name == "Settings")
        {
            if (PlayerPrefs.GetString("Music") == "off")
            {
                transform.GetChild(0).gameObject.GetComponent<Image>().sprite = mus_off;
                Camera.main.GetComponent<AudioListener>().enabled = false;//Switch off music
            }
        }
    }



    void OnMouseDown()
    {
        transform.localScale = new Vector3 (bigger, bigger, bigger);
    }

    void OnMouseUp()
    {
        transform.localScale = new Vector3(lower, lower, lower);
    }

    void OnMouseUpAsButton()
    {
        switch (gameObject.name)
        {

           case "Restart":
                  SceneManager.LoadScene("main");
                  break;

            case "Facebook":
                Application.OpenURL("https://facebook.com");
                break;

            case "Twitter":
                Application.OpenURL("https://twitter.com");
                break;

            case "Google+":
                Application.OpenURL("https://google.com");
                break;


            case "Music":
                if (PlayerPrefs.GetString("Music") == "off") //Play music now
                {
                    GetComponent<Image>().sprite = mus_on;
                    PlayerPrefs.SetString("Music", "on");
                    Camera.main.GetComponent<AudioListener>().enabled = true;//Switch on music
                }
                else
                {// off music
                    GetComponent<Image>().sprite = mus_off;
                    PlayerPrefs.SetString("Music", "off");
                    Camera.main.GetComponent<AudioListener>().enabled = false;//Switch off music
                }
                break;



            case "Settings":
                for (int i = 0; i < transform.childCount; i++)
                    transform.GetChild(i).gameObject.SetActive(!transform.GetChild(i).gameObject.activeSelf);
                break;

                case "Shop":
                shopBG.SetActive (!shopBG.activeSelf);
                break;

                case "Close":
                shopBG.SetActive (false);
                break;
        }
    }
}
