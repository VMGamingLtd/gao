using RecipeManagement;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ResearchTooltip : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private TooltipObjectsItems itemTooltipObjects;
    private TooltipFollowMouse tooltipFollowMouse;
    private RecipeCreator recipeCreator;
    private TranslationManager translationManager;
    private Transform requirementsStatList;
    private Transform rewardsStatList;
    private GameObject stat;
    public bool exitedTooltip;

    private void Awake()
    {
        itemTooltipObjects = GameObject.Find("TooltipCanvas/TooltipObjectsItems").GetComponent<TooltipObjectsItems>();
        translationManager = GameObject.Find("TranslationManager").GetComponent<TranslationManager>();
        recipeCreator = GameObject.Find("RecipeCreatorList").GetComponent<RecipeCreator>();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (GlobalCalculator.GameStarted)
        {
            StartCoroutine(DisplayTooltip(eventData.pointerEnter.transform.parent.name));
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        HideAllTooltips();
        exitedTooltip = true;
    }

    private GameObject FindTooltipObject(string objectName)
    {
        foreach (GameObject tooltipObj in itemTooltipObjects.tooltipObjectItems)
        {
            if (tooltipObj.name == objectName)
            {
                return tooltipObj;
            }
        }
        return null;
    }

    /// <summary>
    /// Displays the actual tooltip after mouse over where object name is also the actual ID of the entry in the json file ResearchListJson.
    /// </summary>
    /// <param name="objectName"></param>
    /// <returns></returns>
    public IEnumerator DisplayTooltip(string objectName)
    {
        HideAllTooltips();
        GameObject tooltipObject = FindTooltipObject("ResearchTooltip");
        if (tooltipObject != null)
        {
            if (tooltipObject.transform.parent.TryGetComponent(out tooltipFollowMouse))
            {
                tooltipFollowMouse.enabled = true;
            }

            exitedTooltip = false;
            FadeCanvasGroup(tooltipObject, 0);
            float timer = 0f;
            float totalTime = 0.1f;
            float delay = 0.5f;
            tooltipObject.SetActive(true);

            if (int.TryParse(objectName, out int objectID))
            {
                var researchData = recipeCreator.researchDataList[objectID];

                if (researchData != null)
                {
                    tooltipObject.transform.Find("Header/Title").GetComponent<TextMeshProUGUI>().text = translationManager.Translate(researchData.projectName);
                    tooltipObject.transform.Find("Header/Image/Icon").GetComponent<Image>().sprite = AssignSkillSpriteToSlot(researchData.projectName);
                    tooltipObject.transform.Find("Product").GetComponent<TextMeshProUGUI>().text = translationManager.Translate(researchData.projectProduct);
                    tooltipObject.transform.Find("Type").GetComponent<TextMeshProUGUI>().text = translationManager.Translate(researchData.projectType);
                    tooltipObject.transform.Find("Class").GetComponent<TextMeshProUGUI>().text = translationManager.Translate(researchData.projectClass);
                    tooltipObject.transform.Find("Desc").GetComponent<TextMeshProUGUI>().text = translationManager.Translate(researchData.projectName + "Desc");
                    tooltipObject.transform.Find("RequirementsTitle").GetComponent<TextMeshProUGUI>().text = translationManager.Translate("Requirements");
                    tooltipObject.transform.Find("RewardsTitle").GetComponent<TextMeshProUGUI>().text = translationManager.Translate("Rewards");

                    stat = GameObject.Find("ItemCreatorList/BuildingTooltipStatTemplate");

                    requirementsStatList = tooltipObject.transform.Find("RequirementsList").GetComponent<Transform>();
                    rewardsStatList = tooltipObject.transform.Find("RewardsList").GetComponent<Transform>();

                    if (researchData.hasRequirements)
                    {
                        foreach (ChildData requirementItem in researchData.requirementsList)
                        {
                            CreateRequirementStat(requirementItem);
                        }
                    }
                    else
                    {
                        tooltipObject.transform.Find("RequirementsTitle").gameObject.SetActive(false);
                    }

                    foreach (ChildData rewardItem in researchData.rewardsList)
                    {
                        CreateRewardStat(rewardItem);
                    }
                }
            }

            yield return new WaitForSeconds(delay);
            if (!exitedTooltip)
            {
                while (timer < totalTime)
                {
                    timer += Time.deltaTime;
                    float normalizedTime = Mathf.Clamp01(timer / totalTime);
                    FadeCanvasGroup(tooltipObject, normalizedTime);
                    yield return null;
                }
            }
        }
    }

    /// <summary>
    /// Instantiates a game object inside Research tooltip - RequirementStatList game object with values from json file.
    /// </summary>
    /// <param name="childData"></param>
    private void CreateRequirementStat(ChildData childData)
    {
        GameObject newStat = Instantiate(stat, requirementsStatList);
        newStat.transform.Find("Name").GetComponent<TextMeshProUGUI>().text = translationManager.Translate(childData.name);
        newStat.transform.Find("Value").GetComponent<TextMeshProUGUI>().text = childData.quantity.ToString();

        if (childData.type == "SKILLPOINT")
        {
            newStat.transform.Find("Icon").GetComponent<Image>().sprite = AssignResourceSpriteToSlot(childData.name);
        }
        else
        {
            newStat.transform.Find("Icon").GetComponent<Image>().sprite = AssignBuildingSpriteToSlot(childData.name);
        }

        newStat.transform.localPosition = Vector3.one;
        newStat.transform.localScale = Vector3.one;
    }

    /// <summary>
    /// Instantiates a game object inside Research tooltip - RewardStatList game object with values from json file.
    /// </summary>
    /// <param name="childData"></param>
    private void CreateRewardStat(ChildData childData)
    {
        GameObject newStat = Instantiate(stat, rewardsStatList);
        newStat.transform.Find("Name").GetComponent<TextMeshProUGUI>().text = translationManager.Translate(childData.name);

        if (childData.type == "SKILLPOINT")
        {
            newStat.transform.Find("Icon").GetComponent<Image>().sprite = AssignResourceSpriteToSlot(childData.name);
            newStat.transform.Find("Value").GetComponent<TextMeshProUGUI>().text = childData.quantity.ToString();
        }
        else if (childData.type == "GENERALSTAT")
        {
            GameObject childIcon = newStat.transform.Find("Icon").gameObject;
            childIcon.SetActive(false);

            if (childData.name == "AllProduction")
            {
                newStat.transform.Find("Value").GetComponent<TextMeshProUGUI>().text = childData.quantity.ToString() + " + %";
            }
        }
        else
        {
            newStat.transform.Find("Icon").GetComponent<Image>().sprite = AssignBuildingSpriteToSlot(childData.name);
            newStat.transform.Find("Value").GetComponent<TextMeshProUGUI>().text = translationManager.Translate("Blueprint");
        }

        newStat.transform.localPosition = Vector3.one;
        newStat.transform.localScale = Vector3.one;
    }

    private Sprite AssignBuildingSpriteToSlot(string spriteName)
    {
        Sprite sprite = AssetBundleManager.LoadAssetFromBundle<Sprite>("buildingicons", spriteName);
        return sprite;
    }

    private Sprite AssignSkillSpriteToSlot(string spriteName)
    {
        Sprite sprite = AssetBundleManager.LoadAssetFromBundle<Sprite>("skillicons", spriteName);
        return sprite;
    }

    private Sprite AssignResourceSpriteToSlot(string spriteName)
    {
        Sprite sprite = AssetBundleManager.LoadAssetFromBundle<Sprite>("resourceicons", spriteName);
        return sprite;
    }

    /// <summary>
    /// Fades the alpha value of the Canvas object over a desired time to create 'FadeIn' or 'FadeOut' transition effect.
    /// </summary>
    /// <param name="targetObject"></param>
    /// <param name="alpha"></param>
    private void FadeCanvasGroup(GameObject targetObject, float alpha)
    {
        if (targetObject.transform.parent.TryGetComponent<CanvasGroup>(out var canvasGroup))
        {
            canvasGroup.alpha = alpha;
        }
    }

    public void HideAllTooltips()
    {
        foreach (GameObject tooltipObject in itemTooltipObjects.tooltipObjectItems)
        {
            if (tooltipObject.activeSelf)
            {
                tooltipObject.SetActive(false);

                foreach (Transform child in requirementsStatList)
                {
                    Destroy(child.gameObject);
                }

                foreach (Transform child2 in rewardsStatList)
                {
                    Destroy(child2.gameObject);
                }
            }
        }
    }
}
