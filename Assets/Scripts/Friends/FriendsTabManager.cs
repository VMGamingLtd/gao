using Cysharp.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Friends
{
    public class FriendsTabManager : MonoBehaviour
    {
        public class FriendModel
        {
            public string UserName { get; set; }
            public int UserId { get; set; }
            public bool Gui_IsLineVisible { get; set; }
        }

        //private static int MAX_SCROLL_LIST_LINES_CPUNT = 100;
        private static int MAX_SCROLL_LIST_LINES_COUNT = 10;

        public GameObject FriendsButton;
        public Transform List; // scroll list containing friends buttons

        public GameObject Title;
        public TMP_Text TitleText;



        public GameObject RemoveFromFriendsDialog;
        public TMP_Text RemoveFriomFriendsDialogText;

        // reference to gameobject ChatTab / Viewport / MESSAGELIST
        public Chat.MessageList messageList;
        // reference to gameobject ChatTab
        public GameObject chatTab;

        private string State_RemoveFromFriendsDialog_message; 
        private int State_RemoveFromFriendsDialog_index_filtered; 


        public TMP_InputField SearchTextBox;

        private FriendModel[] AllUsers = new FriendModel[MAX_SCROLL_LIST_LINES_COUNT]; 
        private int LastIndexAllUsers = -1;

        private int[] FilteredUsers = new int[MAX_SCROLL_LIST_LINES_COUNT];
        private int LastIndexFilteredUsers = -1;

        private GameObject[] AllFriendsButtons = new GameObject[MAX_SCROLL_LIST_LINES_COUNT]; // all friends buttons in the scroll list
        private int LastIndexAllFriendsButtons = -1;

        private async UniTaskVoid Init()
        {
            // get my group

            SetTitleText();

            await GuiReadAllUsersList();

            SearchTextBox.onValueChanged.AddListener(OnSearchTextBoxChange); // TODO

        }

        private async UniTask  GuiReadAllUsersList()
        {
            RemoveAllFriendsButtons();
            await ReadAllUsers();
            AllocateFriendsButtons();
            FilterUsers("");
            DisplayFilteredUsers();
            DisplayTitle(); 
        }

        private void SetTitleText()
        {
                string message =  "My Friends";
                switch(Application.systemLanguage)
                {
                    case SystemLanguage.English:
                        message = "My Friends";
                    break;
                    case SystemLanguage.Russian:
                        message = "Мои друзья";
                    break;
                    case SystemLanguage.Chinese:
                        message = "我的朋友";
                    break;
                    case SystemLanguage.Slovak:
                        message = "Moji priatelia";
                    break;
                    default:
                        message = "My Friends";
                    break;
                }
                TitleText.text = message;
        }

        public void RemoveAllFriendsButtons()
        {
            foreach (Transform child in List)
            {
                GameObject.Destroy(child.gameObject);
            }
            LastIndexAllFriendsButtons = -1;
        }

        private async UniTask ReadAllUsers()
        {

            Debug.Log("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@ cp200 ReadAllUsers()");
            //Gaos.Routes.Model.FriendsJson.GetUsersListResponse response = await Gaos.Friends.Friends.GetUsersList.CallAsync(frienNameSubstring, MAX_SCROLL_LIST_LINES_COUNT);
            Gaos.Routes.Model.FriendJson.GetMyFriendsResponse response = await Gaos.Friends.GetMyFriends.CallAsync("", MAX_SCROLL_LIST_LINES_COUNT);
            if (response == null)
            {
                // error occured
                return; 
            }
            LastIndexAllUsers = -1;
            if (response == null)
            {
                return; 
            }

            for (int i = 0; i < response.Users.Length; i++)
            {

                // fill in friends array
                AllUsers[++LastIndexAllUsers] = new FriendModel {
                    UserId = response.Users[i].UserId,
                    UserName = response.Users[i].UserName,
                    Gui_IsLineVisible = true
                };

                // linit maximal number of users to be desplayed
                if (i + 1 == MAX_SCROLL_LIST_LINES_COUNT)
                {
                    // TODO: maake backend return no more than MAX_SCROLL_LIST_LINES_CPUNT users
                    break;
                }
            }

        }

        private void AllocateFriendsButtons()
        {
            int n = (LastIndexAllUsers + 1) - (LastIndexAllFriendsButtons + 1);
            while (n > 0)
            {
                GameObject friendsButton = Instantiate(FriendsButton, List);
                friendsButton.transform.position = Vector3.zero;
                friendsButton.SetActive(false);
                AllFriendsButtons[++LastIndexAllFriendsButtons] = friendsButton;
                --n;

            }
        }

        private void FilterUsers(string substring)
        {
            LastIndexFilteredUsers = -1;

            for (int i = 0; i <= LastIndexAllUsers; i++)
            {
                if (substring == "" || substring == null || AllUsers[i].UserName.Contains(substring))
                {
                    FilteredUsers[++LastIndexFilteredUsers] = i;
                }
            }
        }


        public void OnSearchTextBoxChange(string text)
        {
            Debug.Log($"@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@ cp 455: OnSearchTextBoxChange(): {text}");
            FilterUsers(text);
            DisplayFilteredUsers();
            DisplayTitle();
        }

        public void OnEnable()
        {
            RemoveAllFriendsButtons();
            SearchTextBox.text = ""; 
            Init().Forget();
        }

        public void DisplayTitle()
        {
            Title.SetActive(true);
            RemoveFromFriendsDialog.SetActive(false);
        }

        public async UniTaskVoid OnButtonRemoveFromFriendsYesAsync()
        {
            int index_all = FilteredUsers[State_RemoveFromFriendsDialog_index_filtered];
            FriendModel user = AllUsers[index_all];
            var response = await Gaos.Friends.RemoveFriend.CallAsync(user.UserId);
            if (response == null)
            {
                // error occured
                return;
            }
        }

        public void OnButtonRemoveFromFriendsYes()
        {
            Debug.Log($"@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@ cp 910: OnButtonRemoveFromGroupYes()");
            Debug.Log($"@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@ cp 920: {State_RemoveFromFriendsDialog_index_filtered}");
            OnButtonRemoveFromFriendsYesAsync().Forget();

            int index_all = FilteredUsers[State_RemoveFromFriendsDialog_index_filtered];

            DisplayTitle();

            FriendModel user = AllUsers[index_all];
            user.Gui_IsLineVisible = false;
            DisplayFilteredUsers();
        }

        public void OnButtonRemoveFromFriendsNo() {
            DisplayTitle();
        }

        public void DisplayRemoveFromFriendsDialog()
        {
            RemoveFriomFriendsDialogText.text = State_RemoveFromFriendsDialog_message;

            Title.SetActive(false);
            RemoveFromFriendsDialog.SetActive(true);
        }

        private void OnButtonRemoveFromFriendsClicked(int index_filtered)
        {
            Debug.Log($"@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@ cp 300: OnButtonRemoveFromGroupClicked(): {index_filtered}");
            int index_all = FilteredUsers[index_filtered];
            FriendModel user = AllUsers[index_all];

            {
                string message;
                switch (Application.systemLanguage)
                {
                    case SystemLanguage.English:
                        message = $"Remove {user.UserName} from friends?";
                        break;
                    case SystemLanguage.Russian:
                        message = $"Удалить {user.UserName} из друзей?";
                        break;
                    case SystemLanguage.Chinese:
                        message = $"从好友中删除 {user.UserName}?";
                        break;
                    case SystemLanguage.Slovak:
                        message = $"Odstrániť {user.UserName} z priateľov?";
                        break;
                    default:
                        message = $"Remove {user.UserName} from friends?";
                        break;
                }
                State_RemoveFromFriendsDialog_message = message;
            }
            State_RemoveFromFriendsDialog_index_filtered = index_filtered;

            DisplayRemoveFromFriendsDialog();
        }

        private UnityAction  MakeOnButtonRemoveFromGFriendsClicked(int index_filtered)
        {
            return () =>
            {
                OnButtonRemoveFromFriendsClicked(index_filtered);
            };
        }

        private async UniTaskVoid OnButtonChatClickedAsync(int index_filtered)
        {
            Debug.Log($"@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@ cp 400: OnButtonChatClicked(): {index_filtered}");
            int index_all = FilteredUsers[index_filtered];
            FriendModel user = AllUsers[index_all];

            Gaos.Routes.Model.ChatRoomJson.GetUserToFriendChatRoomResponse responseChatRoom = await Gaos.ChatRoom.ChatRoom.GetUserToFriendChatRoom.CallAsync(user.UserId);
            Debug.Log($"@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@ cp 500: chatroom name: {responseChatRoom.ChatRoomName}");
            messageList.SetChatRoomName(responseChatRoom.ChatRoomName);
            chatTab.SetActive(true);

        }

        private void OnButtonChatClicked(int index_filtered)
        {
            OnButtonChatClickedAsync(index_filtered).Forget();
        }

        private UnityAction MakeOnButtonChatClicked(int index_filtered)
        {
            return () =>
            {
                OnButtonChatClicked(index_filtered);
            };
        }

        public void DisplayFriendButton(int index_filtered)
        { 
            int index_all = FilteredUsers[index_filtered];
            FriendModel user = AllUsers[index_all];

            Transform childObject_friendUsername = AllFriendsButtons[index_all].transform.Find("Info/FriendUsername");
            TextMeshProUGUI friendUsername = childObject_friendUsername.GetComponent<TextMeshProUGUI>();
            friendUsername.text = user.UserName;

            Transform childObject_friendStatus = AllFriendsButtons[index_all].transform.Find("Info/Status");
            TextMeshProUGUI friendStatus = childObject_friendStatus.GetComponent<TextMeshProUGUI>();
            friendStatus.text = "unknown";

            Transform childObject_buttonRemoveFromGroup = AllFriendsButtons[index_all].transform.Find("ButtonRemoveFromFriends");
            Button buttonRemoveFromGroup = childObject_buttonRemoveFromGroup.GetComponent<Button>();

            Transform childObject_buttonChat = AllFriendsButtons[index_all].transform.Find("Chat");
            Button buttonChat = childObject_buttonChat.GetComponent<Button>();

            childObject_buttonRemoveFromGroup.gameObject.SetActive(false);
            childObject_buttonChat.gameObject.SetActive(false);

            buttonRemoveFromGroup.onClick.RemoveAllListeners();
            buttonRemoveFromGroup.onClick.AddListener(MakeOnButtonRemoveFromGFriendsClicked(index_filtered));
            childObject_buttonRemoveFromGroup.gameObject.SetActive(true);

            buttonChat.onClick.RemoveAllListeners();
            buttonChat.onClick.AddListener(MakeOnButtonChatClicked(index_filtered));
            childObject_buttonChat.gameObject.SetActive(true);


        }

        private void DisplayFilteredUsers()
        {
            for (int i = 0; i <= LastIndexFilteredUsers; i++)
            {
                int index = FilteredUsers[i];
                FriendModel user = AllUsers[index];

                if (user.Gui_IsLineVisible)
                {
                    AllFriendsButtons[i].SetActive(true);

                    DisplayFriendButton(i);
                }
                else
                {
                    AllFriendsButtons[i].SetActive(false);
                }

            }

            for (int i = LastIndexFilteredUsers + 1; i <= LastIndexAllFriendsButtons; i++)
            {
                AllFriendsButtons[i].SetActive(false);
            }
        }

        private async UniTaskVoid OnSearchButtonClickAsync(string userNamePattern)
        {
            await GuiReadAllUsersList();
        }


        public void OnSearchButtonClick()
        {
            Debug.Log($"@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@ cp 400: OnSearchIconClick(): {SearchTextBox.text}");
            SearchTextBox.text = "";
            OnSearchButtonClickAsync(SearchTextBox.text).Forget();
            DisplayTitle();
        }

    }
}
