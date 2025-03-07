using Cysharp.Threading.Tasks;
using Gaos.Routes.Model.GroupJson;
using UnityEngine;

public class FriendsGroupTabLoader : MonoBehaviour
{
    private GetMyGroupResponse myGroupResponse;
    private bool isMyGroupLoaded = false;

    public GameObject friendsTabForGroupOwner;


    // Start is called before the first frame update
    void Start()
    {
        isMyGroupLoaded = false;
        GetMyGroups().Forget();

    }

    private async UniTaskVoid GetMyGroups()
    {
        myGroupResponse = await Gaos.Groups.Groups.GetMyGroup.CallAsync();
        if (myGroupResponse == null)
        {
            Debug.Log("ERROR: error calling server: GetMyGroup");
        }
        else
        {
            isMyGroupLoaded = true;
            if (myGroupResponse.IsGroupOwner)
            {
                Debug.Log("I am the group owner.");
            }
            else
            {
                if (myGroupResponse.IsGroupMember)
                {
                    Debug.Log($"I am in the group user {myGroupResponse.GroupOwnerName} .");
                }
                else
                {
                    Debug.Log("I am neither group owner nor member of any group.");
                }
            }
        }
    }

    public void OnFriendsPanelClick()
    {
        Debug.Log("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@ cp 2350:Friends Panel Clicked");
        if (isMyGroupLoaded)
        {
            if (myGroupResponse.IsError == false)
            {
                if ((myGroupResponse.IsGroupOwner == true) || (!myGroupResponse.IsGroupOwner && !myGroupResponse.IsGroupMember))
                {
                    // display friends panel for group owner
                    friendsTabForGroupOwner.SetActive(true);
                    Animator animator = friendsTabForGroupOwner.GetComponent<Animator>();
                    if (animator != null)
                    {
                        animator.Play("Window In");
                    }
                    else
                    {
                        Debug.Log("ERROR: Animator not found");
                    }
                }
                else
                {
                    // display friends panel for group member
                }
            }
            else
            {
                Debug.Log("Error Getting My Group");
                isMyGroupLoaded = false;
                GetMyGroups().Forget();
            }
        }
        else
        {
            Debug.Log("My Group Not Loaded");
        }
    }

}
