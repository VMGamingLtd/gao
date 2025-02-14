using UnityEngine;
using TMPro;
using Cysharp.Threading.Tasks;

namespace Chat
{
    public class ChatOpenerForFriends : MonoBehaviour
    {
        public static string CLASS_NAME = typeof(ChatOpenerForFriends).Name;
        
        // reference to gameobject ChatTab / Viewport / MESSAGELIST
        public MessageList messageList;
        // reference to gameobject ChatTabs
        public GameObject chatTab;

        public void OpenChatWithUser()
        {
            const string METHOD_NAME = "OpenChatWithUser";

            Transform parent = transform.parent;
            Transform usernameObject = parent.Find("Info/FriendUsername");

            if (usernameObject != null)
            {
                TextMeshProUGUI usernameText = usernameObject.GetComponent<TextMeshProUGUI>();

                if (usernameText != null)
                {
                    string userName = usernameText.text;
                    messageList.SetChatRoomName($"Friends_{userName}");
                    Debug.Log($"{CLASS_NAME}:{METHOD_NAME}: Opened chat room of user: " + userName);
                }
                else
                {
                    Debug.LogWarning($"{CLASS_NAME}:{METHOD_NAME}: Info/FriendUsername TextMeshProUGUI object not found in parent.");
                }
            }
            else
            {
                string userName = Gaos.Context.Authentication.GetUserName();
                if (userName != null)
                {
                    messageList.SetChatRoomName($"Friends_{userName}");
                    Debug.Log($"{CLASS_NAME}:{METHOD_NAME}: Opened chat room of logged in user: " + userName);
                }
                else
                {
                    Debug.LogWarning($"{CLASS_NAME}:{METHOD_NAME}: user not logged in");
                    Debug.LogWarning($"{CLASS_NAME}:{METHOD_NAME}: cannot determine the user for chat root");
                }
            }
        }

        /*
        public void GetTargetUsername()
        {
            //return messageList.targetUsername;
        }
        */
    }
}
