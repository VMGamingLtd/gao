using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Login : MonoBehaviour
{
    private readonly static string CLASS_NAME = typeof(Login).Name;

    public TMP_InputField EmailInputField;
    public TMP_InputField UserNameInputField;
    public TMP_InputField PasswordInputField;

    public TextMeshProUGUI errorText;

    public void OnButtonClick()
    {
        StartCoroutine(LoginUser());
    }

    private IEnumerator LoginUser()
    {
        yield return new WaitUntil(() => Gaos.Device.Device.Registration.IsDeviceRegistered == true);
        StartCoroutine(Gaos.User.User.UserLogin.Login( UserNameInputField.text, PasswordInputField.text, OnUserLoginComplete));
    }

    private void OnUserLoginComplete()
    {
        const string METHOD_NAME = "OnUserLoginComplete()";
        if (Gaos.User.User.UserLogin.IsLoggedIn)
        {
            Debug.Log($"{CLASS_NAME}:{METHOD_NAME}: User login successful");
        }
        else
        {
            throw new System.Exception("User login failed");
        }
    }
}
