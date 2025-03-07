using BuildingManagement;
using Cysharp.Threading.Tasks;
using System.Threading;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BuildingStatisticsManager : MonoBehaviour
{
    public GameObject RowObject;
    public Transform objectList;
    public BuildingManager buildingManager;
    public static string BuildingStatisticProcess = "Electricity";
    public static string BuildingStatisticType = "ALLTYPES";
    public static string BuildingStatisticInterval = "1 second";
    private bool updateUI;
    private CancellationTokenSource updateCancellation;

    public async UniTaskVoid OnEnable()
    {
        BuildingIntervalTypes.BuildingIntervalTypeChanged = true;
        await LoadBuildingStatisticsAsync();
    }

    public async UniTask LoadBuildingStatisticsAsync()
    {
        updateCancellation?.Cancel();
        updateUI = true;
        bool showAllTypes = BuildingStatisticType == "ALLTYPES";
        foreach (Transform child in objectList)
        {
            Destroy(child.gameObject);
        }

        if (buildingManager.buildingArrays != null && buildingManager.buildingArrays.Count > 0)
        {
            foreach (var kvp in buildingManager.buildingArrays)
            {
                GameObject[] itemArray = kvp.Value;

                foreach (GameObject item in itemArray)
                {
                    if (kvp.Key == "POWERPLANT")
                    {
                        EnergyBuildingItemData itemDataEnergy = item.GetComponent<EnergyBuildingItemData>();
                        bool showItem = showAllTypes || BuildingStatisticType == itemDataEnergy.buildingType;
                        if (showItem)
                        {
                            GameObject rowObject = Instantiate(RowObject, objectList);
                            rowObject.SetActive(true);
                            UpperGraphManager upperGraphManager = rowObject.transform.Find("GraphObject/UPPERGRAPHMANAGER").GetComponent<UpperGraphManager>();
                            rowObject.transform.position = Vector3.zero;
                            UpdateRowWithEnergyDataOnce(rowObject, itemDataEnergy, item);
                            UpdateEnergyGraph(upperGraphManager, itemDataEnergy);
                        }
                    }
                    else
                    {
                        BuildingItemData itemData = item.GetComponent<BuildingItemData>();
                        bool showItem = showAllTypes || BuildingStatisticType == itemData.buildingType;
                        if (showItem)
                        {
                            GameObject rowObject = Instantiate(RowObject, objectList);
                            rowObject.SetActive(true);
                            UpperGraphManager upperGraphManager = rowObject.transform.Find("GraphObject/UPPERGRAPHMANAGER").GetComponent<UpperGraphManager>();
                            rowObject.transform.position = Vector3.zero;
                            UpdateRowWithDataOnce(rowObject, itemData, item);
                            UpdateGraph(upperGraphManager, itemData);
                        }
                    }


                }
            }
        }
        await UpdateItemDataAsync();
    }

    private async UniTask UpdateItemDataAsync()
    {
        updateCancellation = new CancellationTokenSource();
        while (updateUI)
        {
            bool showAllTypes = BuildingStatisticType == "ALLTYPES";
            await UniTask.Delay(200, cancellationToken: updateCancellation.Token);
            int currentRowIndex = 0;

            if (buildingManager.buildingArrays != null && buildingManager.buildingArrays.Count > 0)
            {
                foreach (var kvp in buildingManager.buildingArrays)
                {
                    GameObject[] itemArray = kvp.Value;

                    foreach (GameObject item in itemArray)
                    {
                        if (kvp.Key == "POWERPLANT")
                        {
                            EnergyBuildingItemData itemData = item.GetComponent<EnergyBuildingItemData>();
                            bool showItem =
                            (showAllTypes || BuildingStatisticType == itemData.buildingType);
                            if (showItem)
                            {
                                UpdateRowObjectsWithEnergyData(itemData, ref currentRowIndex);
                            }
                        }
                        else
                        {
                            BuildingItemData itemData = item.GetComponent<BuildingItemData>();
                            bool showItem =
                            (showAllTypes || BuildingStatisticType == itemData.buildingType);
                            if (showItem)
                            {
                                UpdateRowObjectsWithData(itemData, ref currentRowIndex);
                            }
                        }
                    }
                }
            }
        }
    }
    private void UpdateRowObjectsWithData(BuildingItemData itemData, ref int currentRowIndex)
    {
        int objectListCount = objectList.childCount;
        if (currentRowIndex < objectListCount)
        {
            Transform rowTransform = objectList.GetChild(currentRowIndex);
            GameObject rowObject = rowTransform.gameObject;
            UpperGraphManager upperGraphManager = rowObject.transform.Find("GraphObject/UPPERGRAPHMANAGER").GetComponent<UpperGraphManager>();
            UpdateRowWithData(rowObject, itemData);
            UpdateGraph(upperGraphManager, itemData);
            currentRowIndex++;
        }
    }
    private void UpdateRowObjectsWithEnergyData(EnergyBuildingItemData itemData, ref int currentRowIndex)
    {
        int objectListCount = objectList.childCount;
        if (currentRowIndex < objectListCount)
        {
            Transform rowTransform = objectList.GetChild(currentRowIndex);
            GameObject rowObject = rowTransform.gameObject;
            UpperGraphManager upperGraphManager = rowObject.transform.Find("GraphObject/UPPERGRAPHMANAGER").GetComponent<UpperGraphManager>();
            UpdateRowWithEnergyData(rowObject, itemData);
            UpdateEnergyGraph(upperGraphManager, itemData);
            currentRowIndex++;
        }
    }
    private void UpdateEnergyGraph(UpperGraphManager upperGraphManager, EnergyBuildingItemData itemData)
    {
        if (BuildingStatisticInterval == "1 second")
        {
            upperGraphManager.FillGraph(itemData.powerCycleData.secondCycle);
        }
        else if (BuildingStatisticInterval == "10 seconds")
        {
            upperGraphManager.FillGraph(itemData.powerCycleData.tenSecondCycle);
        }
        else if (BuildingStatisticInterval == "30 seconds")
        {
            upperGraphManager.FillGraph(itemData.powerCycleData.thirtySecondCycle);
        }
        else if (BuildingStatisticInterval == "1 minute")
        {
            upperGraphManager.FillGraph(itemData.powerCycleData.minuteCycle);
        }
        else if (BuildingStatisticInterval == "10 minutes")
        {
            upperGraphManager.FillGraph(itemData.powerCycleData.tenMinuteCycle);
        }
        else if (BuildingStatisticInterval == "30 minutes")
        {
            upperGraphManager.FillGraph(itemData.powerCycleData.thirtyMinuteCycle);
        }
        else if (BuildingStatisticInterval == "1 hour")
        {
            upperGraphManager.FillGraph(itemData.powerCycleData.hourCycle);
        }
        else if (BuildingStatisticInterval == "6 hours")
        {
            upperGraphManager.FillGraph(itemData.powerCycleData.sixHourCycle);
        }
    }
    private void UpdateGraph(UpperGraphManager upperGraphManager, BuildingItemData itemData)
    {
        if (BuildingStatisticInterval == "1 second")
        {
            upperGraphManager.FillGraph(itemData.powerConsumptionCycleData.secondCycle);
        }
        else if (BuildingStatisticInterval == "10 seconds")
        {
            upperGraphManager.FillGraph(itemData.powerConsumptionCycleData.tenSecondCycle);
        }
        else if (BuildingStatisticInterval == "30 seconds")
        {
            upperGraphManager.FillGraph(itemData.powerConsumptionCycleData.thirtySecondCycle);
        }
        else if (BuildingStatisticInterval == "1 minute")
        {
            upperGraphManager.FillGraph(itemData.powerConsumptionCycleData.minuteCycle);
        }
        else if (BuildingStatisticInterval == "10 minutes")
        {
            upperGraphManager.FillGraph(itemData.powerConsumptionCycleData.tenMinuteCycle);
        }
        else if (BuildingStatisticInterval == "30 minutes")
        {
            upperGraphManager.FillGraph(itemData.powerConsumptionCycleData.thirtyMinuteCycle);
        }
        else if (BuildingStatisticInterval == "1 hour")
        {
            upperGraphManager.FillGraph(itemData.powerConsumptionCycleData.hourCycle);
        }
        else if (BuildingStatisticInterval == "6 hours")
        {
            upperGraphManager.FillGraph(itemData.powerConsumptionCycleData.sixHourCycle);
        }
    }
    private void UpdateRowWithDataOnce(GameObject rowObject, BuildingItemData itemData, GameObject item)
    {
        TextMeshProUGUI buildingNameText = rowObject.transform.Find("Name").GetComponent<TextMeshProUGUI>();
        Image rowImage = rowObject.transform.Find("Icon/Image").GetComponent<Image>();
        TextMeshProUGUI powerOutputText = rowObject.transform.Find("ProductionCount").GetComponent<TextMeshProUGUI>();
        TextMeshProUGUI consumptionOutputText = rowObject.transform.Find("ConsumptionCount").GetComponent<TextMeshProUGUI>();
        string spriteName = itemData.spriteIconName;
        buildingNameText.text = itemData.buildingName;
        consumptionOutputText.text = itemData.powerConsumption.ToString();
        rowImage.sprite = AssignSpriteToSlot(spriteName);
    }
    private void UpdateRowWithEnergyDataOnce(GameObject rowObject, EnergyBuildingItemData itemData, GameObject item)
    {
        TextMeshProUGUI buildingNameText = rowObject.transform.Find("Name").GetComponent<TextMeshProUGUI>();
        Image rowImage = rowObject.transform.Find("Icon/Image").GetComponent<Image>();
        TextMeshProUGUI powerOutputText = rowObject.transform.Find("ProductionCount").GetComponent<TextMeshProUGUI>();
        TextMeshProUGUI consumptionOutputText = rowObject.transform.Find("ConsumptionCount").GetComponent<TextMeshProUGUI>();
        string spriteName = itemData.spriteIconName;
        buildingNameText.text = itemData.buildingName;
        powerOutputText.text = itemData.actualPowerOutput.ToString();
        rowImage.sprite = AssignSpriteToSlot(spriteName);
    }

    private void UpdateRowWithData(GameObject rowObject, BuildingItemData itemData)
    {
        TextMeshProUGUI powerOutputText = rowObject.transform.Find("ProductionCount").GetComponent<TextMeshProUGUI>();
        TextMeshProUGUI consumptionOutputText = rowObject.transform.Find("ConsumptionCount").GetComponent<TextMeshProUGUI>();
        consumptionOutputText.text = itemData.powerConsumption.ToString();
    }
    private void UpdateRowWithEnergyData(GameObject rowObject, EnergyBuildingItemData itemData)
    {
        TextMeshProUGUI powerOutputText = rowObject.transform.Find("ProductionCount").GetComponent<TextMeshProUGUI>();
        TextMeshProUGUI consumptionOutputText = rowObject.transform.Find("ConsumptionCount").GetComponent<TextMeshProUGUI>();
        powerOutputText.text = itemData.actualPowerOutput.ToString();
    }

    private Sprite AssignSpriteToSlot(string spriteName)
    {
        Sprite sprite = AssetBundleManager.LoadAssetFromBundle<Sprite>("buildingicons", spriteName);
        return sprite;
    }
    private void OnDisable()
    {
        updateUI = false;
        updateCancellation?.Cancel(); // Cancel the async operation
    }
}
