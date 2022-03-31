using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SteveMove : MonoBehaviour
{
    // Start is called before the first frame update
    Transform Steve; 
    void Start()
    {
       Steve = GetComponent<Transform>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown()
    {
        Steve.Translate(0, 0.5f, 0);

    }
}
