using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingIron : MonoBehaviour
{

    private BuildingWork buildingWork;
    private int workersCurrent;


    void Update()
    {
        buildingWork = GetComponent<BuildingWork>();
        workersCurrent = buildingWork.getWorkersCurrent();
        buildingWork.ironPerMinute = 5 * workersCurrent;
    }
}
