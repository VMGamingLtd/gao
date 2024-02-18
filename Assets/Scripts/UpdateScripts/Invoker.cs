using UnityEngine;
using UnityEngine.UI;

public class Invoker : MonoBehaviour
{
    public Button buttonToClick;
    public Button buttonToClick2;
    public int StatusNumber;

    // Update is called once per frame
    void Awake()
    {
        buttonToClick.onClick.Invoke();
        StatusNumber = 0;
    }

    public void SetStatusNumber(int Number)
    {
        StatusNumber = Number;
    }

    private void OnEnable()
    {
        if (StatusNumber == 0)
        {
            buttonToClick.onClick.Invoke();
        }
        else if (StatusNumber == 1)
        {
            buttonToClick2.onClick.Invoke();
        }
    }

}