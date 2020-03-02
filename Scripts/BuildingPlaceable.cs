using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class BuildingPlaceable : MonoBehaviour
{

    [HideInInspector]
    public List<Collider> colliders = new List<Collider>();

    private bool isSelected;


    private void OnTriggerEnter(Collider c) 
    {
        if (c.tag == "Buldings")
        {
            colliders.Add(c);
           
        }
    }
    private void OnTriggerExit(Collider c)
    {
        if (c.tag == "Buldings")
        {
            colliders.Remove(c);
          
        }
    }

    public void SetSelected(bool s)
    {
        isSelected = s;
    }
}
