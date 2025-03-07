using BuildingManagement;
using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace BuildingManagement
{
    [Serializable]
    public class BuildingDataJson
    {
        public int index;
        public string buildingName;
        public string buildingType;
        public string buildingClass;
        public int consumedSlotCount;
        public List<SlotItemData> consumedItems;
        public int producedSlotCount;
        public List<SlotItemData> producedItems;
        public float totalTime;
        public int basePowerOutput;
        public int powerConsumption;
        public float researchPoints;
    }
    [Serializable]
    public class EnergyBuildingItemData : MonoBehaviour
    {
        public int index;
        public int ID;
        public string spriteIconName;
        public string buildingType;
        public string buildingName;
        public string buildingClass;
        public Vector3 buildingPosition;
        public List<SlotItemData> consumedItems;
        public List<SlotItemData> producedItems;
        public PowerCycle powerCycleData = new();
        public int consumedSlotCount;
        public float timer;
        public float totalTime;
        public int secondCycleCount;
        public int minuteCycleCount;
        public int hourCycleCount;
        public int powerOutput;
        public int basePowerOutput;
        public int actualPowerOutput;
        public int efficiency;
        public int efficiencySetting;
        public int buildingCount;
        public bool isPaused;
        public bool enlistedProduction;

        public EnergyBuildingItemData()
        {
            consumedItems = new List<SlotItemData>();
            producedItems = new List<SlotItemData>();
        }
    }

    [Serializable]
    public class BuildingItemData : MonoBehaviour
    {
        public int index;
        public int ID;
        public string spriteIconName;
        public string buildingType;
        public string buildingName;
        public string buildingClass;
        public Vector3 buildingPosition;
        public List<SlotItemData> consumedItems;
        public List<SlotItemData> producedItems;
        public PowerConsumptionCycle powerConsumptionCycleData = new();
        public ProductionCycle productionCycleData = new();
        public int consumedSlotCount;
        public float timer;
        public float totalTime;
        public int secondCycleCount;
        public int minuteCycleCount;
        public int hourCycleCount;
        public int powerConsumption;
        public int actualPowerConsumption;
        public int producedSlotCount;
        public int efficiency;
        public int efficiencySetting;
        public int buildingCount;
        public bool isPaused;
        public bool enlistedProduction;

        public BuildingItemData()
        {
            consumedItems = new List<SlotItemData>();
            producedItems = new List<SlotItemData>();
        }
    }

    [Serializable]
    public class ResearchBuildingItemData : MonoBehaviour
    {
        public int index;
        public int ID;
        public string spriteIconName;
        public string buildingType;
        public string buildingName;
        public string buildingClass;
        public Vector3 buildingPosition;
        public List<SlotItemData> consumedItems;
        public PowerConsumptionCycle powerConsumptionCycleData = new();
        public int consumedSlotCount;
        public float timer;
        public float totalTime;
        public int powerConsumption;
        public int actualPowerConsumption;
        public int efficiency;
        public int efficiencySetting;
        public int buildingCount;
        public bool isPaused;
        public bool enlistedProduction;
        public float researchPoints;

        public ResearchBuildingItemData()
        {
            consumedItems = new List<SlotItemData>();
        }
    }

    [Serializable]
    public class PowerCycle
    {
        public float[] secondCycle = new float[120];
        public float[] tenSecondCycle = new float[120];
        public float[] thirtySecondCycle = new float[120];
        public float[] minuteCycle = new float[120];
        public float[] tenMinuteCycle = new float[120];
        public float[] thirtyMinuteCycle = new float[120];
        public float[] hourCycle = new float[120];
        public float[] sixHourCycle = new float[120];
    }
    public class PowerConsumptionCycle
    {
        public float[] secondCycle = new float[120];
        public float[] tenSecondCycle = new float[120];
        public float[] thirtySecondCycle = new float[120];
        public float[] minuteCycle = new float[120];
        public float[] tenMinuteCycle = new float[120];
        public float[] thirtyMinuteCycle = new float[120];
        public float[] hourCycle = new float[120];
        public float[] sixHourCycle = new float[120];
    }
    public class ProductionCycle
    {
        public float[] secondCycle = new float[120];
        public float[] tenSecondCycle = new float[120];
        public float[] thirtySecondCycle = new float[120];
        public float[] minuteCycle = new float[120];
        public float[] tenMinuteCycle = new float[120];
        public float[] thirtyMinuteCycle = new float[120];
        public float[] hourCycle = new float[120];
        public float[] sixHourCycle = new float[120];
    }


    [Serializable]
    public class SlotItemData
    {
        public int index;
        public string itemName;
        public string itemQuality;
        public float quantity;
    }
}

public class BuildingCreator : MonoBehaviour
{
    public GameObject buildingTemplate;
    public GameObject smallPowerGridTemplate;
    public GameObject newItemParent;
    public BuildingManager buildingManager;
    public BuildingIncrementor buildingIncrementor;
    public TranslationManager translationManager;
    private BuildingItemData itemData;
    private EnergyBuildingItemData itemDataEnergy;
    private ResearchBuildingItemData itemDataResearch;
    public List<BuildingDataJson> buildingDataList;
    private GameObject objectTemplate;
    public RectTransform BuildingArea;
    public static int BuildingUniqueID;

    [Serializable]
    private class JsonArray
    {
        public List<BuildingDataJson> buildings;
    }
    private void Awake()
    {
        objectTemplate = GameObject.Find("BuildingCreatorList/BuildingTemplate");
        string jsonText = Assets.Scripts.Models.BuildingsListJson.json;
        JsonArray jsonArray = JsonUtility.FromJson<JsonArray>(jsonText);
        if (jsonArray != null)
        {
            buildingDataList = jsonArray.buildings;
        }
    }

    public void RecreateResearchBuilding(int index, string buildingName, string buildingType, string buildingClass, int consumedSlotCount,
        List<SlotItemData> consumedItems, float totalTime, int powerConsumption, float timer, int actualPowerConsumption, int efficiency,
        int efficiencySetting, int buildingCount, bool isPaused, Vector3 buildingPosition, PowerConsumptionCycle powerConsumptionCycle,
        string spriteIconName, int ID, bool enlistedProduction, float researchPoints)
    {
        RecreateResearchBuilding(objectTemplate, index, buildingName, buildingType, buildingClass, consumedSlotCount, consumedItems,
            totalTime, powerConsumption, timer, actualPowerConsumption, efficiency, efficiencySetting, buildingCount, isPaused, buildingPosition,
            powerConsumptionCycle, spriteIconName, ID, enlistedProduction, researchPoints);
    }

    private void RecreateResearchBuilding(GameObject objectTemplate, int index, string buildingName, string buildingType, string buildingClass, int consumedSlotCount,
          List<SlotItemData> consumedItems, float totalTime, int powerConsumption, float timer, int actualPowerConsumption, int efficiency, int efficiencySetting,
          int buildingCount, bool isPaused, Vector3 buildingPosition, PowerConsumptionCycle powerConsumptionCycle, string spriteIconName, int ID,
          bool enlistedProduction, float researchPoints)
    {
        GameObject newBuilding = Instantiate(objectTemplate, BuildingArea);
        itemDataResearch = newBuilding.AddComponent<ResearchBuildingItemData>();
        itemDataResearch.buildingType = buildingType;
        itemDataResearch.buildingPosition = buildingPosition;
        newBuilding.transform.localPosition = buildingPosition;
        itemDataResearch.index = index;
        newBuilding.name = spriteIconName;
        itemDataResearch.buildingClass = buildingClass;
        itemDataResearch.consumedSlotCount = consumedSlotCount;
        itemDataResearch.consumedItems = consumedItems;
        itemDataResearch.totalTime = totalTime;
        itemDataResearch.powerConsumption = powerConsumption;
        itemDataResearch.actualPowerConsumption = actualPowerConsumption;
        itemDataResearch.efficiencySetting = 100;
        itemDataResearch.timer = timer;
        itemDataResearch.efficiency = efficiency;
        itemDataResearch.efficiencySetting = efficiencySetting;
        itemDataResearch.buildingCount = buildingCount;
        itemDataResearch.isPaused = isPaused;
        itemDataResearch.powerConsumptionCycleData = powerConsumptionCycle;
        itemDataResearch.spriteIconName = spriteIconName;
        itemDataResearch.ID = ID;
        itemDataResearch.enlistedProduction = enlistedProduction;
        itemDataResearch.researchPoints = researchPoints;
        newBuilding.tag = Constants.ResearchTag;

        translationManager = GameObject.Find("TranslationManager").GetComponent<TranslationManager>();
        itemDataResearch.buildingName = buildingName;
        newBuilding.AddComponent<ResearchBuildingCycles>();
        newBuilding.AddComponent<DragAndDropBuildings>();
        buildingManager.AddToItemArray(buildingType, newBuilding);
        buildingIncrementor.InitializeBuildingCounts();
        newBuilding.transform.localScale = Vector3.one;
        newBuilding.transform.Find("Icon").GetComponent<Image>().sprite = AssignSpriteToSlot(spriteIconName);
    }

    public void RecreateProductionBuilding(int index, string buildingName, string buildingType, string buildingClass, int consumedSlotCount, int producedSlotCount,
        List<SlotItemData> consumedItems, List<SlotItemData> producedItems, float totalTime, int powerConsumption, float timer, int actualPowerConsumption, int efficiency,
        int efficiencySetting, int buildingCount, bool isPaused, Vector3 buildingPosition, int secondCycleCount, int minuteCycleCount, int hourCycleCount,
        PowerConsumptionCycle powerConsumptionCycle, ProductionCycle productionCycle, string spriteIconName, int ID, bool enlistedProduction)
    {
        RecreateProductionBuilding(objectTemplate, index, buildingName, buildingType, buildingClass, consumedSlotCount, producedSlotCount, consumedItems, producedItems,
            totalTime, powerConsumption, timer, actualPowerConsumption, efficiency, efficiencySetting, buildingCount, isPaused, buildingPosition,
            secondCycleCount, minuteCycleCount, hourCycleCount, powerConsumptionCycle, productionCycle, spriteIconName, ID, enlistedProduction);
    }

    private void RecreateProductionBuilding(GameObject objectTemplate, int index, string buildingName, string buildingType, string buildingClass, int consumedSlotCount,
          int producedSlotCount, List<SlotItemData> consumedItems, List<SlotItemData> producedItems, float totalTime, int powerConsumption, float timer, int actualPowerConsumption,
          int efficiency, int efficiencySetting, int buildingCount, bool isPaused, Vector3 buildingPosition, int secondCycleCount, int minuteCycleCount, int hourCycleCount,
          PowerConsumptionCycle powerConsumptionCycle, ProductionCycle productionCycle, string spriteIconName, int ID, bool enlistedProduction)
    {
        GameObject newBuilding = Instantiate(objectTemplate, BuildingArea);
        itemData = newBuilding.AddComponent<BuildingItemData>();
        itemData.buildingType = buildingType;
        itemData.buildingPosition = buildingPosition;
        newBuilding.transform.localPosition = buildingPosition;
        itemData.index = index;
        newBuilding.name = spriteIconName;
        itemData.buildingClass = buildingClass;
        itemData.consumedSlotCount = consumedSlotCount;
        itemData.producedSlotCount = producedSlotCount;
        itemData.consumedItems = consumedItems;
        itemData.producedItems = producedItems;
        itemData.totalTime = totalTime;
        itemData.powerConsumption = powerConsumption;
        itemData.actualPowerConsumption = actualPowerConsumption;
        itemData.efficiencySetting = 100;
        itemData.timer = timer;
        itemData.efficiency = efficiency;
        itemData.efficiencySetting = efficiencySetting;
        itemData.buildingCount = buildingCount;
        itemData.isPaused = isPaused;
        itemData.secondCycleCount = secondCycleCount;
        itemData.minuteCycleCount = minuteCycleCount;
        itemData.hourCycleCount = hourCycleCount;
        itemData.powerConsumptionCycleData = powerConsumptionCycle;
        itemData.productionCycleData = productionCycle;
        itemData.spriteIconName = spriteIconName;
        itemData.ID = ID;
        itemData.enlistedProduction = enlistedProduction;

        if (newBuilding.name == Constants.WaterPump)
        {
            newBuilding.tag = Constants.NoConsumeTag;
        }
        else if (newBuilding.name == Constants.FibrousPlantField)
        {
            newBuilding.tag = Constants.ConsumeTag;
        }
        else if (newBuilding.name == Constants.Boiler)
        {
            newBuilding.tag = Constants.ConsumeTag;
        }
        else if (newBuilding.name == Constants.SteamGenerator)
        {
            newBuilding.tag = Constants.EnergyTag;
        }
        else if (newBuilding.name == Constants.Furnace)
        {
            newBuilding.tag = Constants.ConsumeTag;
        }

        translationManager = GameObject.Find("TranslationManager").GetComponent<TranslationManager>();
        itemData.buildingName = buildingName;
        newBuilding.AddComponent<BuildingCycles>();
        newBuilding.AddComponent<DragAndDropBuildings>();
        buildingManager.AddToItemArray(buildingType, newBuilding);
        buildingIncrementor.InitializeBuildingCounts();
        newBuilding.transform.localScale = Vector3.one;
        newBuilding.transform.Find("Icon").GetComponent<Image>().sprite = AssignSpriteToSlot(spriteIconName);
    }

    public void RecreateEnergyBuilding(int index, string buildingName, string buildingType, string buildingClass, int consumedSlotCount,
        List<SlotItemData> consumedItems, float totalTime, int basePowerOutput, float timer, int actualPowerOutput, int powerOutput, int efficiency,
        int efficiencySetting, int buildingCount, bool isPaused, Vector3 buildingPosition, int secondCycleCount, int minuteCycleCount, int hourCycleCount,
        PowerCycle powerCycleData, string spriteIconName, int ID, bool enlistedProduction)
    {
        RecreateEnergyBuilding(objectTemplate, index, buildingName, buildingType, buildingClass, consumedSlotCount, consumedItems, totalTime,
            basePowerOutput, timer, actualPowerOutput, powerOutput, efficiency, efficiencySetting, buildingCount, isPaused, buildingPosition,
            secondCycleCount, minuteCycleCount, hourCycleCount, powerCycleData, spriteIconName, ID, enlistedProduction);
    }

    private void RecreateEnergyBuilding(GameObject objectTemplate, int index, string buildingName, string buildingType, string buildingClass, int consumedSlotCount,
          List<SlotItemData> consumedItems, float totalTime, int basePowerOutput, float timer, int actualPowerOutput, int powerOutput, int efficiency, int efficiencySetting,
          int buildingCount, bool isPaused, Vector3 buildingPosition, int secondCycleCount, int minuteCycleCount, int hourCycleCount, PowerCycle powerCycleData, string spriteIconName,
          int ID, bool enlistedProduction)
    {
        GameObject newBuilding = Instantiate(objectTemplate, BuildingArea);
        itemDataEnergy = newBuilding.AddComponent<EnergyBuildingItemData>();
        itemDataEnergy.buildingType = buildingType;
        itemDataEnergy.buildingPosition = buildingPosition;
        newBuilding.transform.localPosition = buildingPosition;
        itemDataEnergy.index = index;
        newBuilding.name = spriteIconName;
        itemDataEnergy.buildingClass = buildingClass;
        itemDataEnergy.consumedSlotCount = consumedSlotCount;
        itemDataEnergy.consumedItems = consumedItems;
        itemDataEnergy.totalTime = totalTime;
        itemDataEnergy.basePowerOutput = basePowerOutput;
        itemDataEnergy.actualPowerOutput = actualPowerOutput;
        itemDataEnergy.powerOutput = powerOutput;
        itemDataEnergy.efficiencySetting = 100;
        itemDataEnergy.timer = timer;
        itemDataEnergy.efficiency = efficiency;
        itemDataEnergy.efficiencySetting = efficiencySetting;
        itemDataEnergy.buildingCount = buildingCount;
        itemDataEnergy.isPaused = isPaused;
        itemDataEnergy.secondCycleCount = secondCycleCount;
        itemDataEnergy.minuteCycleCount = minuteCycleCount;
        itemDataEnergy.hourCycleCount = hourCycleCount;
        itemDataEnergy.powerCycleData = powerCycleData;
        itemDataEnergy.spriteIconName = spriteIconName;
        itemDataEnergy.ID = ID;
        itemDataEnergy.enlistedProduction = enlistedProduction;
        newBuilding.tag = Constants.EnergyTag;
        translationManager = GameObject.Find("TranslationManager").GetComponent<TranslationManager>();
        itemDataEnergy.buildingName = buildingName;
        newBuilding.AddComponent<EnergyBuildingCycles>();
        newBuilding.AddComponent<DragAndDropBuildings>();
        buildingManager.AddToItemArray(buildingType, newBuilding);
        buildingIncrementor.InitializeBuildingCounts();
        newBuilding.transform.localScale = Vector3.one;
        newBuilding.transform.Find("Icon").GetComponent<Image>().sprite = AssignSpriteToSlot(spriteIconName);
    }

    public void CreateBuilding(GameObject draggedObject, int buildingIndex)
    {
        var itemData = buildingDataList[buildingIndex];

        CreateBuilding(draggedObject,
                    itemData.index,
                    itemData.buildingName,
                    itemData.buildingType,
                    itemData.buildingClass,
                    itemData.consumedSlotCount,
                    itemData.consumedItems,
                    itemData.producedSlotCount,
                    itemData.producedItems,
                    itemData.totalTime,
                    itemData.basePowerOutput,
                    itemData.powerConsumption,
                    itemData.researchPoints);
    }
    private void CreateBuilding(GameObject draggedObject,
                                int index,
                                string buildingName,
                                string buildingType,
                                string buildingClass,
                                int consumedSlotCount,
                                List<SlotItemData> slotItemData,
                                int producedSlotCount,
                                List<SlotItemData> producedItemData,
                                float totalTime,
                                int powerOutput,
                                int powerConsumption,
                                float researchPoints)
    {
        CoroutineManager coroutineManager = GameObject.Find("CoroutineManager").GetComponent<CoroutineManager>();

        if (buildingType == Constants.Powerplant)
        {
            itemDataEnergy = draggedObject.AddComponent<EnergyBuildingItemData>();
            itemDataEnergy.buildingType = buildingType;
            itemDataEnergy.buildingPosition = draggedObject.GetComponent<RectTransform>().anchoredPosition3D;
            itemDataEnergy.index = index;
            draggedObject.name = buildingName;
            itemDataEnergy.buildingClass = buildingClass;
            itemDataEnergy.consumedSlotCount = consumedSlotCount;
            itemDataEnergy.consumedItems = slotItemData;
            itemDataEnergy.producedItems = producedItemData;
            itemDataEnergy.totalTime = totalTime;
            itemDataEnergy.powerOutput = powerOutput;
            itemDataEnergy.efficiencySetting = 100;
            itemDataEnergy.isPaused = false;
            BuildingUniqueID++;
            itemDataEnergy.ID = BuildingUniqueID;
            itemDataEnergy.spriteIconName = draggedObject.transform.Find("Icon").GetComponent<Image>().sprite.name;

            if (draggedObject.name == Constants.BiofuelGenerator)
            {
                Planet0Buildings.Planet0BiofuelGenerator++;
                Planet0Buildings.Planet0BiofuelGeneratorBlueprint--;
                itemDataEnergy.buildingCount = Planet0Buildings.Planet0BiofuelGenerator;
                coroutineManager.UpdateBuildingText(Constants.BiofuelGenerator, Planet0Buildings.Planet0BiofuelGeneratorBlueprint.ToString());
            }

            draggedObject.tag = Constants.EnergyTag;
            translationManager = GameObject.Find("TranslationManager").GetComponent<TranslationManager>();
            string titleText = draggedObject.transform.Find("Title").GetComponent<TextMeshProUGUI>().text = translationManager.Translate(buildingName);
            itemDataEnergy.buildingName = $"{titleText} #{itemDataEnergy.buildingCount}";
            draggedObject.AddComponent<EnergyBuildingCycles>();
        }
        else if (buildingType == Constants.Laboratory)
        {
            itemDataResearch = draggedObject.AddComponent<ResearchBuildingItemData>();
            itemDataResearch.buildingType = buildingType;
            itemDataResearch.buildingPosition = draggedObject.GetComponent<RectTransform>().anchoredPosition3D;
            itemDataResearch.index = index;
            draggedObject.name = buildingName;
            itemDataResearch.buildingClass = buildingClass;
            itemDataResearch.consumedSlotCount = consumedSlotCount;
            itemDataResearch.consumedItems = slotItemData;
            itemDataResearch.totalTime = totalTime;
            itemDataResearch.powerConsumption = powerConsumption;
            itemDataResearch.efficiencySetting = 100;
            itemDataResearch.isPaused = false;
            itemDataResearch.researchPoints = researchPoints;
            BuildingUniqueID++;
            itemDataResearch.ID = BuildingUniqueID;
            itemDataResearch.spriteIconName = draggedObject.transform.Find("Icon").GetComponent<Image>().sprite.name;

            if (draggedObject.name == Constants.ResearchDevice)
            {
                Planet0Buildings.Planet0ResearchDevice++;
                Planet0Buildings.Planet0ResearchDeviceBlueprint--;
                itemData.buildingCount = Planet0Buildings.Planet0ResearchDevice;
                coroutineManager.UpdateBuildingText(Constants.ResearchDevice, Planet0Buildings.Planet0ResearchDeviceBlueprint.ToString());
            }

            draggedObject.tag = Constants.ResearchTag;
            translationManager = GameObject.Find("TranslationManager").GetComponent<TranslationManager>();
            string titleText = draggedObject.transform.Find("Title").GetComponent<TextMeshProUGUI>().text = translationManager.Translate(buildingName);
            itemDataResearch.buildingName = $"{titleText} #{itemData.buildingCount}";
            draggedObject.AddComponent<ResearchBuildingCycles>();
        }
        else
        {
            itemData = draggedObject.AddComponent<BuildingItemData>();
            itemData.buildingType = buildingType;
            itemData.buildingPosition = draggedObject.GetComponent<RectTransform>().anchoredPosition3D;
            itemData.index = index;
            draggedObject.name = buildingName;
            itemData.buildingClass = buildingClass;
            itemData.consumedSlotCount = consumedSlotCount;
            itemData.producedSlotCount = producedSlotCount;
            itemData.consumedItems = slotItemData;
            itemData.producedItems = producedItemData;
            itemData.totalTime = totalTime;
            itemData.powerConsumption = powerConsumption;
            itemData.efficiencySetting = 100;
            itemData.isPaused = false;
            BuildingUniqueID++;
            itemData.ID = BuildingUniqueID;
            itemData.spriteIconName = draggedObject.transform.Find("Icon").GetComponent<Image>().sprite.name;

            if (draggedObject.name == Constants.WaterPump)
            {
                Planet0Buildings.Planet0WaterPump++;
                Planet0Buildings.Planet0WaterPumpBlueprint--;
                itemData.buildingCount = Planet0Buildings.Planet0WaterPump;
                draggedObject.tag = Constants.NoConsumeTag;
                coroutineManager.UpdateBuildingText(Constants.WaterPump, Planet0Buildings.Planet0WaterPumpBlueprint.ToString());
            }
            else if (draggedObject.name == Constants.FibrousPlantField)
            {
                Planet0Buildings.Planet0FibrousPlantField++;
                Planet0Buildings.Planet0FibrousPlantFieldBlueprint--;
                itemData.buildingCount = Planet0Buildings.Planet0FibrousPlantField;
                draggedObject.tag = Constants.ConsumeTag;
                coroutineManager.UpdateBuildingText(Constants.FibrousPlantField, Planet0Buildings.Planet0FibrousPlantFieldBlueprint.ToString());
            }
            else if (draggedObject.name == Constants.Boiler)
            {
                Planet0Buildings.Planet0Boiler++;
                Planet0Buildings.Planet0BoilerBlueprint--;
                itemData.buildingCount = Planet0Buildings.Planet0Boiler;
                draggedObject.tag = Constants.ConsumeTag;
                coroutineManager.UpdateBuildingText(Constants.Boiler, Planet0Buildings.Planet0BoilerBlueprint.ToString());
            }
            else if (draggedObject.name == Constants.SteamGenerator)
            {
                Planet0Buildings.Planet0SteamGenerator++;
                Planet0Buildings.Planet0SteamGeneratorBlueprint--;
                itemDataEnergy.buildingCount = Planet0Buildings.Planet0SteamGenerator;
                draggedObject.tag = Constants.EnergyTag;
                coroutineManager.UpdateBuildingText(Constants.SteamGenerator, Planet0Buildings.Planet0SteamGeneratorBlueprint.ToString());
            }
            else if (draggedObject.name == Constants.Furnace)
            {
                Planet0Buildings.Planet0Furnace++;
                Planet0Buildings.Planet0FurnaceBlueprint--;
                itemData.buildingCount = Planet0Buildings.Planet0Furnace;
                draggedObject.tag = Constants.ConsumeTag;
                coroutineManager.UpdateBuildingText(Constants.Furnace, Planet0Buildings.Planet0FurnaceBlueprint.ToString());
            }

            translationManager = GameObject.Find("TranslationManager").GetComponent<TranslationManager>();
            string titleText = draggedObject.transform.Find("Title").GetComponent<TextMeshProUGUI>().text = translationManager.Translate(buildingName);
            itemData.buildingName = $"{titleText} #{itemData.buildingCount}";
            draggedObject.AddComponent<BuildingCycles>();
        }

        buildingManager.AddToItemArray(buildingType, draggedObject);
        buildingIncrementor.InitializeBuildingCounts();

        if (GoalManager.thirdGoal == false)
        {
            GoalManager goalManager = GameObject.Find("GOALMANAGER").GetComponent<GoalManager>();
            _ = goalManager.SetFourthGoal();
        }
    }

    private Sprite AssignSpriteToSlot(string spriteName)
    {
        Sprite sprite = AssetBundleManager.LoadAssetFromBundle<Sprite>("buildingicons", spriteName);
        return sprite;
    }
}
