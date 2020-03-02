using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingPlacement : MonoBehaviour
{
    private BuildingPlaceable buildingPlaceable;

    private Transform currentBuilding;

    private Camera cam;

    private bool IsPlaced; 

    public LayerMask buildingMask;



    void Start()
    {
        cam = Camera.main;
    }


    void Update()
    {

        Vector3 mouse = Input.mousePosition;
        mouse = new Vector3(mouse.x, mouse.y, transform.position.y);
        Vector3 pos = cam.ScreenToWorldPoint(mouse);

        if (currentBuilding != null && !IsPlaced)
        {
            
            currentBuilding.position = new Vector3(pos.x, 0, pos.z);

            if (IsLegalPosition())
            {

                Renderer r = currentBuilding.GetComponent<Renderer>();
                Material m = r.material;
                m.color = Color.green;
            }
            else
            {
                Renderer r = currentBuilding.GetComponent<Renderer>();
                Material m = r.material;
                m.color = Color.red;
            }
        }

        

        if (Input.GetMouseButtonDown(0))
        {
            if (IsLegalPosition())
            {
                IsPlaced = true;
                Renderer r = currentBuilding.GetComponent<Renderer>();
                Material m = r.material;
                m.color = Color.white;
            }
        
        }
    }

    bool IsLegalPosition()
    {
        if (buildingPlaceable.colliders.Count > 0)
        {
            return false;
        }
        else
        return true;
    }

    public void SetItem(GameObject obj)
    {
        IsPlaced = false;
        currentBuilding = ((GameObject)Instantiate(obj)).transform;
        buildingPlaceable = currentBuilding.GetComponent<BuildingPlaceable>();
    }
}
