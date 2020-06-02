using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSameColor : MonoBehaviour
{
    private bool firstOne;
    void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.tag == "Cube"&& firstOne)
            other.gameObject.GetComponent<MeshRenderer>().material.color = GetComponent<MeshRenderer>().material.color;
        if (!firstOne)
            firstOne = true;
    }
}
