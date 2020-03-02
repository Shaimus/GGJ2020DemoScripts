using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingWork : MonoBehaviour
{
    private int workersTotal = 5;
    public int workersCurrent = 0;

    public int woodPerMinute;
    public int ironPerMinute;

    public Vector3 center = new Vector3 (0.0f, 0.0f, 0.0f);

    public VillagersList vlist;

    Resources resources;


    void Start()
    {
        resources = GameObject.FindObjectOfType<Resources>();
        InvokeRepeating("addResource", 2.0f, 2f);
        vlist = GameObject.FindObjectOfType<VillagersList>();
    }



    public void incrementWorkersCurrent()
    {
        if (workersCurrent < 5)
        {
            workersCurrent++;
            vlist.GetComponent<VillagersList>().makeVillagerBusy(transform.position);
        }
    }

    public void decrementWorcersCurrent()
    {
        if (workersCurrent > 0)
        {
            workersCurrent--;
            vlist.GetComponent<VillagersList>().makeVillagerFree(center);
        }
    }

    public int getWorkersCurrent()
    {
        return workersCurrent;
    }

    public int getWorkersTotal()
    {
        return workersTotal;
    }

    private void addResource()
    {
        resources.changeWood(woodPerMinute);
        resources.changeIron(ironPerMinute);
    }

}
