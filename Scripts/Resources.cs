using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Resources : MonoBehaviour
{

    private int wood;
    private int iron;
    private int food;
    private int water;

    public Text woodText;
    public Text ironText;
    public Text foodText;
    public Text waterText;



    
    void Update()
    {
        woodText.text = wood.ToString();
        ironText.text = iron.ToString();
        foodText.text = food.ToString();
        waterText.text = water.ToString();
    }

    public int getWood()
    {
        return wood;
    }

    public int getIron()
    {
        return iron;
    }

    public int getFood()
    {
        return food;
    }

    public int getWater()
    {
        return water;
    }

    public void changeWood(int num)
    {
        wood += num;
    }

    public void changeIron(int num)
    {
        iron += num;
    }

    public void changeFood(int num)
    {
        food += num;
    }

    public void changeWater(int num)
    {
        water += num;
    }
}
