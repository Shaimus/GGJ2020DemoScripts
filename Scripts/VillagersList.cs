using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VillagersList : MonoBehaviour
{
    public List<GameObject> villagers = new List<GameObject>();
    public int villagersNum;
    public int villagersFreeNum;
    private int villagerCount;
    public Text villagerText;



    
    void Update()
    {
        villagerCount = 0;
        foreach (GameObject villager in villagers)
        {
            if (villager.GetComponent<Villager>().isFree)
            {
                villagerCount++;
            }
        }
        villagersNum = villagers.Count;
        villagersFreeNum = villagerCount;
        villagerText.text = villagersFreeNum + "/" + villagersNum;

    }

    public void makeVillagerBusy(Vector3 destination)
    {
        for (int i = 0; i < 10; i++)
        {
            if (villagers[i].GetComponent<Villager>().isFree)
            {
                villagers[i].GetComponent<Villager>().setDestination(destination);
                villagers[i].GetComponent<Villager>().isWalking = true;
                
                villagers[i].GetComponent<Villager>().isFree = false;
                break;
            }
        }
    }

    public void makeVillagerFree(Vector3 destination)
    {
        for (int i = 0; i < 10; i++)
        {
            if (!villagers[i].GetComponent<Villager>().isFree)
            {
                villagers[i].GetComponent<Villager>().setDestination(destination);
                villagers[i].GetComponent<Villager>().isWalking = true;

                villagers[i].GetComponent<Villager>().isFree = true;
                break;
            }
        }
    }
}
