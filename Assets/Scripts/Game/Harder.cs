using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Harder : MonoBehaviour
{
    public GameObject _dc;
    private bool hard;
    void Update()
    {
       
        if (CubeJump.count_blocks > 0)
        {
            
            if (CubeJump.count_blocks % 5 == 0 && !hard)
            {
                print("Harder");
                Camera.main.GetComponent<Animation>().Play("Harder");
                hard = true;
                _dc.transform.position = new Vector3(11.56f, 7.2f, -5.1449f);
                _dc.transform.eulerAngles = new Vector3(29.4282f, 299.942f, 0f);

            }
            else if ((CubeJump.count_blocks % 5)-1 == 0 && hard)
            {
                hard = false;
                print("Easy");
                Camera.main.GetComponent<Animation>().Play("Easy");
                _dc.transform.position = new Vector3(0f, 0f, -5f);
                _dc.transform.eulerAngles = new Vector3(0f, 0f, 0f);
            }
        }
    }
}