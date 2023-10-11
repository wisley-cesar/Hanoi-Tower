using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimento : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    void OnMouseDrag()
    {
        // Moves an object up 2 units
        transform.position += new Vector3(0, 2, 0);
    }
}   
