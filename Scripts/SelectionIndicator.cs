using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionIndicator : MonoBehaviour
{
    MouseManager mm;

    void Start()
    {
        mm = GameObject.FindObjectOfType<MouseManager>();
    }


    void Update()
    {
     if (mm.hoveredObject != null)
        {
            GetComponentInChildren<Renderer>().enabled = true;
            Bounds bounds = mm.hoveredObject.GetComponentInChildren<Renderer>().bounds;

            float diameter = bounds.size.z;
            diameter *= 1.35f;

            this.transform.position = new Vector3(bounds.center.x, 0, bounds.center.z);
            this.transform.localScale = new Vector3(bounds.size.x, bounds.size.y, bounds.size.z);
        }   

     else
        {
            GetComponentInChildren<Renderer>().enabled = false; 
        }
    }
}
