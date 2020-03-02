using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingWood : MonoBehaviour
{

    private BuildingWork buildingWork;
    private int workersCurrent;


    void Update()
    {
        buildingWork = GetComponent<BuildingWork>();
        workersCurrent = buildingWork.getWorkersCurrent();
        buildingWork.woodPerMinute = 5 * workersCurrent;
    }
}
