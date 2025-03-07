using TMPro;
using UnityEngine;

public class RegisterStatusLoad : MonoBehaviour
{
    public readonly static string CLASS_NAME = typeof(LoginMenuManager).Name;

    public TextMeshProUGUI DisplayedText;
    private TranslationManager translationManager;

    void Awake()
    {
        translationManager = GameObject.Find("TranslationManager").GetComponent<TranslationManager>();
    }
    private enum RegisterStatus
    {
        NotRegistered,
        Registered,
    }

    void OnEnable()
    {
        DisplayedText = GetComponent<TextMeshProUGUI>();
        if (Gaos.Context.Authentication.GetIsGuest())
        {
            DisplayedText.text = GetRegisterStatusText(RegisterStatus.NotRegistered);
        }
        else
        {
            DisplayedText.text = GetRegisterStatusText(RegisterStatus.Registered);
        }
        Assets.Scripts.Login.UserChangedEvent.UserChanged += OnUserChanged;
    }

    private void OnDisable()
    {
        Assets.Scripts.Login.UserChangedEvent.UserChanged -= OnUserChanged;
    }

    private string GetRegisterStatusText(RegisterStatus registerStatus)
    {
        const string METHOD_NAME = "GetRegisterStatusText()";
        string txt = "";

        switch (registerStatus)
        {
            case RegisterStatus.NotRegistered:
                txt = translationManager.Translate("NotRegistered");
                break;
            case RegisterStatus.Registered:
                txt = translationManager.Translate("Registered");
                break;
            default:
                txt = "Error!";
                Debug.Log($"{CLASS_NAME}:{METHOD_NAME}: ERROR: missing translation for: {registerStatus}");
                break;

        }

        return txt;
    }

    private void OnUserChanged(object sender, Assets.Scripts.Login.UserChangedEventArgs args)
    {
        if (args.IsGuest)
        {
            DisplayedText.text = GetRegisterStatusText(RegisterStatus.NotRegistered);
        }
        else
        {
            DisplayedText.text = GetRegisterStatusText(RegisterStatus.Registered);
        }
    }

}
