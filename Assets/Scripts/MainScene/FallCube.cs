using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallCube : MonoBehaviour
{
    
    void Start()
    {
        Destroy(gameObject, 1f);
    }

    void Update()
    {
        transform.position += new Vector3 (0, 0.2f, 0);  
    }
}
