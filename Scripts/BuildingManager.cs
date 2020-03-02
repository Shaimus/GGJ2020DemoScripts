using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingManager : MonoBehaviour
{
    public GameObject[] buildings;
    private BuildingPlacement buildingPlacement;

    void Start()
    {
        buildingPlacement = GetComponent<BuildingPlacement>();
    }



    void OnGUI()
    {

    
        for(int i = 0; i < buildings.Length; i++)
        {
            if (GUI.Button(new Rect(Screen.width / 10 + Screen.width/8 * i, Screen.height - Screen.height / 10, 100, 30), buildings[i].name)) {
                buildingPlacement.SetItem(buildings[i]);
            } 
        }
    }
}
