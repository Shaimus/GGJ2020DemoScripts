using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MouseManager : MonoBehaviour
{

    public GameObject hoveredObject;
    public GameObject selectedObject;
    public Text selectedObjectName;
    public Text selectedObjectDesc;
    public Text workersCount;
    public Button increment;
    public Button decrement;


    void Start()
    {
        increment.onClick.AddListener(btnIncr);
        decrement.onClick.AddListener(btnDecr);
    }

    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        
        RaycastHit hitInfo;

        if (Physics.Raycast(ray, out hitInfo))
        {
            GameObject hitObject = hitInfo.transform.root.gameObject;

            if (Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject())
            {

                SelectObject(hitObject);
            } else if (Input.GetMouseButtonDown(1) && !EventSystem.current.IsPointerOverGameObject())
            {
                ClearSelection();
            }

        }
        else
        {
            if ((Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1)) && !EventSystem.current.IsPointerOverGameObject())
            {
                ClearSelection();
            }
        }

        if (selectedObject != null)
        {
            workersCount.text = selectedObject.GetComponent<BuildingWork>().getWorkersCurrent().ToString();
        }
    }

    void SelectObject(GameObject obj)
    {
        if (hoveredObject != null)
        {
            if (obj == hoveredObject)
            {
                selectedObject = hoveredObject;
                selectedObjectName.text = selectedObject.GetComponentInChildren<BuildingMain>().buildingName;
                selectedObjectDesc.text = selectedObject.GetComponent<BuildingMain>().buildingDesc;
                
                return;
            }

            ClearSelection();
        }
        hoveredObject = obj;
        selectedObject = hoveredObject;
        selectedObjectName.text = selectedObject.GetComponent<BuildingMain>().buildingName;
        selectedObjectDesc.text = selectedObject.GetComponent<BuildingMain>().buildingDesc;
        
    }

    void ClearSelection ()
    {
        hoveredObject = null;
        selectedObject = null;
        selectedObjectName.text = "";
        selectedObjectDesc.text = "";
        workersCount.text = "";

    }

    void btnIncr()
    {
        selectedObject.GetComponent<BuildingWork>().incrementWorkersCurrent();
    }

    void btnDecr()
    {
        selectedObject.GetComponent<BuildingWork>().decrementWorcersCurrent();
    }
}
