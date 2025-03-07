using TMPro;
using UnityEngine;

public class BuildingIncrementor : MonoBehaviour
{
    public TextMeshProUGUI[] buildingCounts;
    public GameObject[] buildings;

    public void InitializeAvailableBuildings()
    {
        if (Planet0Buildings.WaterPumpUnlocked) buildings[1].SetActive(true);
        if (Planet0Buildings.FibrousPlantFieldUnlocked) buildings[2].SetActive(true);
        if (Planet0Buildings.BoilerUnlocked) buildings[3].SetActive(true);
        if (Planet0Buildings.SteamGeneratorUnlocked) buildings[4].SetActive(true);
        if (Planet0Buildings.FurnaceUnlocked) buildings[5].SetActive(true);
        if (Planet0Buildings.ResearchDeviceUnlocked) buildings[6].SetActive(true);
        if (Planet0Buildings.SmallPowerGridUnlocked) buildings[7].SetActive(true);
    }
    public void InitializeBuildingCounts()
    {
        buildingCounts[0].text = Planet0Buildings.Planet0BiofuelGeneratorBlueprint.ToString();
        buildingCounts[1].text = Planet0Buildings.Planet0WaterPumpBlueprint.ToString();
        buildingCounts[2].text = Planet0Buildings.Planet0FibrousPlantFieldBlueprint.ToString();
        buildingCounts[3].text = Planet0Buildings.Planet0BoilerBlueprint.ToString();
        buildingCounts[4].text = Planet0Buildings.Planet0SteamGeneratorBlueprint.ToString();
        buildingCounts[5].text = Planet0Buildings.Planet0FurnaceBlueprint.ToString();
        buildingCounts[6].text = Planet0Buildings.Planet0ResearchDeviceBlueprint.ToString();
        buildingCounts[7].text = Planet0Buildings.Planet0SmallPowerGridBlueprint.ToString();
    }
}
