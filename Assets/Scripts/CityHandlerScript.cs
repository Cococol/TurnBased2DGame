using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CityHandlerScript : MonoBehaviour
{
    [SerializeField]
    private int amountOfBuildings = 1;

    public void SetAmountOfBuildings(int amount)
    {
        amountOfBuildings = amount;
    }

    public void BuyBuildings(string buildingName)
    {
        switch (buildingName)
        {
            case "Farm":
                CalculateBuildings(buildingName);
                break;
            case "Smith":
                CalculateBuildings(buildingName);
                break;
            case "Stable":
                CalculateBuildings(buildingName);
                break;
            case "Tavern":
                CalculateBuildings(buildingName);
                break;
            case "Hotel":
                CalculateBuildings(buildingName);
                break;
            case "Garrison":
                CalculateBuildings(buildingName);
                break;
            case "Market":
                CalculateBuildings(buildingName);
                break;
            case "Castle":
                CalculateBuildings(buildingName);
                break;
        }
    }

    void CalculateBuildings(string building)
    {
        switch (building)
        {
            case "Farm":
                
                break;
            case "Smith":
                
                break;
            case "Stable":
                
                break;
            case "Tavern":
                
                break;
            case "Hotel":
                
                break;
            case "Garrison":
                
                break;
            case "Market":
                
                break;
            case "Castle":

                break;
        }
    }
}
