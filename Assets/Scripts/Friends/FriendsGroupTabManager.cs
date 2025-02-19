using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Events;
using Cysharp.Threading.Tasks;
using System;
using UnityEngine.Rendering;

namespace Friends
{

    public class FriendsGroupTabManager : MonoBehaviour
    {
        private static string CLASS_NAME = typeof(FriendsGroupTabManager).Name;

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

        public GameObject LeaveGroupDialog;
        public TMP_Text LeaveGroupDialogText;

        private string State_LeaveGroupDialog_message;

        public GameObject RemoveFromGroupDialog;
        public TMP_Text RemoveFriomGroupDialogText;

        public GameObject MultiplayerAddPlayerButton;
        public GameObject MultiplayerGroupRequestsButton;

        // reference to gameobject ChatTab / Viewport / MESSAGELIST
        public Chat.MessageList messageList;
        // reference to gameobject ChatTab
        public GameObject chatTab;

        public GameObject groupChatButton;

        private string State_RemoveFromGroupDialog_message;
        private int State_RemoveFromGroupDialog_index_filtered;


        //public GameObject SearchTextBox;
        //public TMP_InputField SearchTextBox;

        private FriendModel[] AllUsers = new FriendModel[MAX_SCROLL_LIST_LINES_COUNT];
        private int LastIndexAllUsers = -1;

        // dictionary of user if to FilteredUsers index
        private Dictionary<int, int> UserToFilteredUsersIndex = new Dictionary<int, int>();

        private int[] FilteredUsers = new int[MAX_SCROLL_LIST_LINES_COUNT];
        private int LastIndexFilteredUsers = -1;

        private GameObject[] AllFriendsButtons = new GameObject[MAX_SCROLL_LIST_LINES_COUNT]; // all friends buttons in the scroll list
        private int LastIndexAllFriendsButtons = -1;

        Gaos.Routes.Model.GroupJson.GetMyGroupResponse GetMyGroupResponse;

        FriendsGroupTabManager()
        {
        }

        private async UniTask GuiReadAllUsersList()
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
            if (GetMyGroupResponse.IsGroupOwner)
            {
                string message = "My Group";
                switch (Application.systemLanguage)
                {
                    case SystemLanguage.English:
                        message = "My Group";
                        break;
                    case SystemLanguage.Russian:
                        message = "Моя группа";
                        break;
                    case SystemLanguage.Chinese:
                        message = "我的组";
                        break;
                    case SystemLanguage.Slovak:
                        message = "Moja skupina";
                        break;
                    default:
                        message = "My Group";
                        break;
                }
                TitleText.text = message;
            }
            else if (GetMyGroupResponse.IsGroupMember)
            {
                string message = $"Group - {GetMyGroupResponse.GroupOwnerName}";
                switch (Application.systemLanguage)
                {
                    case SystemLanguage.English:
                        message = $"Group - {GetMyGroupResponse.GroupOwnerName}";
                        break;
                    case SystemLanguage.Russian:
                        message = $"Группа - {GetMyGroupResponse.GroupOwnerName}";
                        break;
                    case SystemLanguage.Chinese:
                        message = $"组 - {GetMyGroupResponse.GroupOwnerName}";
                        break;
                    case SystemLanguage.Slovak:
                        message = $"Skupina - {GetMyGroupResponse.GroupOwnerName}";
                        break;
                    default:
                        message = $"Group - {GetMyGroupResponse.GroupOwnerName}";
                        break;
                }
                TitleText.text = message;
            }
            else
            {
                string message = "No Group";
                switch (Application.systemLanguage)
                {
                    case SystemLanguage.English:
                        message = "No Group";
                        break;
                    case SystemLanguage.Russian:
                        message = "Нет группы";
                        break;
                    case SystemLanguage.Chinese:
                        message = "没有组";
                        break;
                    case SystemLanguage.Slovak:
                        message = "Žiadna skupina";
                        break;
                    default:
                        message = "No Group";
                        break;
                }
                TitleText.text = message;
            }
        }

        private void DisableOrEnableAddToGroupButton()
        {
            if (GetMyGroupResponse.IsGroupOwner)
            {
                // I can add group members if I am group owner 
                MultiplayerAddPlayerButton.SetActive(true);

                // Nobody can add me to his group as I am group owner (groups are exclusive)
                MultiplayerGroupRequestsButton.SetActive(false);
            }
            else
            {
                if (GetMyGroupResponse.IsGroupMember)
                {
                    // If I am member of the group, I cannot add group members
                    MultiplayerAddPlayerButton.SetActive(false);
                    // As I am already member of the group, I cannot be added to other groups
                    MultiplayerGroupRequestsButton.SetActive(false);
                }
                else
                {
                    // I am neither gorup owner nor group member, I can form a group by inviting other users to join my group.
                    // If any users joins, new group will be created with me as group owner.
                    MultiplayerAddPlayerButton.SetActive(true);

                    // If am meither group owner nor group member, I can be added to other groups
                    MultiplayerGroupRequestsButton.SetActive(true);
                }
            }
        }

        private async UniTaskVoid Init()
        {
            // get my group

            GetMyGroupResponse = await Gaos.Groups.Groups.GetMyGroup.CallAsync();
            if (GetMyGroupResponse == null)
            {
                return;
            }
            SetTitleText();
            DisableOrEnableAddToGroupButton();

            await GuiReadAllUsersList();

            UpdateUnreadMessagesCountsLoop().Forget();

        }

        private async UniTask ReadAllUsers()
        {
            if ((GetMyGroupResponse == null) || (!GetMyGroupResponse.IsGroupOwner && !GetMyGroupResponse.IsGroupMember))
            {
                LastIndexAllUsers = -1;
                return;
            }

            Debug.Log("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@ cp200 ReadAllUsers()");
            //Gaos.Routes.Model.FriendsJson.GetUsersListResponse response = await Gaos.Friends.Friends.GetUsersList.CallAsync(frienNameSubstring, MAX_SCROLL_LIST_LINES_COUNT);
            Gaos.Routes.Model.GroupJson.GetMyGroupMembersResponse response = await Gaos.Groups.Groups.GetMyGroupMembers.CallAsync(GetMyGroupResponse.GroupId, MAX_SCROLL_LIST_LINES_COUNT);
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
                AllUsers[++LastIndexAllUsers] = new FriendModel
                {
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
            UserToFilteredUsersIndex.Clear();

            for (int i = 0; i <= LastIndexAllUsers; i++)
            {
                if (substring == "" || substring == null || AllUsers[i].UserName.Contains(substring))
                {
                    FilteredUsers[++LastIndexFilteredUsers] = i;
                    UserToFilteredUsersIndex.Add(AllUsers[i].UserId, LastIndexFilteredUsers);
                }
            }
        }

        private void OnButtonLeaveGroupClicked(int index_filtered)
        {
            Debug.Log($"@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@ cp 300: OnButtonLeaveGroupClicked(): {index_filtered}");
            State_LeaveGroupDialog_message = "";
            {
                string message;
                switch (Application.systemLanguage)
                {
                    case SystemLanguage.English:
                        message = $"Leave group {GetMyGroupResponse.GroupOwnerName}?";
                        break;
                    case SystemLanguage.Russian:
                        message = $"Покинуть группу {GetMyGroupResponse.GroupOwnerName}?";
                        break;
                    case SystemLanguage.Chinese:
                        message = $"离开组 {GetMyGroupResponse.GroupOwnerName}？";
                        break;
                    case SystemLanguage.Slovak:
                        message = $"Opustiť skupinu {GetMyGroupResponse.GroupOwnerName}?";
                        break;
                    default:
                        message = $"Leave group {GetMyGroupResponse.GroupOwnerName}?";
                        break;
                }
                State_LeaveGroupDialog_message = message;
            }
            DisplayLeaveGroupDialog();
        }

        private UnityAction MakeOnButtonLeaveGroupClicked(int index_filtered)
        {
            return () =>
            {
                OnButtonLeaveGroupClicked(index_filtered);
            };
        }

        private void OnButtonRemoveFromGroupClicked(int index_filtered)
        {
            Debug.Log($"@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@ cp 300: OnButtonRemoveFromGroupClicked(): {index_filtered}");
            int index_all = FilteredUsers[index_filtered];
            FriendModel user = AllUsers[index_all];

            {
                string message;
                switch (Application.systemLanguage)
                {
                    case SystemLanguage.English:
                        message = $"Remove {user.UserName} from group?";
                        break;
                    case SystemLanguage.Russian:
                        message = $"Удалить {user.UserName} из группы?";
                        break;
                    case SystemLanguage.Chinese:
                        message = $"从组中删除 {user.UserName}？";
                        break;
                    case SystemLanguage.Slovak:
                        message = $"Odstrániť {user.UserName} zo skupiny?";
                        break;
                    default:
                        message = $"Remove {user.UserName} from group?";
                        break;
                }
                State_RemoveFromGroupDialog_message = message;
            }
            State_RemoveFromGroupDialog_index_filtered = index_filtered;

            DisplayRemoveFromGroupDialog();
        }

        private UnityAction MakeOnButtonRemoveFromGroupClicked(int index_filtered)
        {
            return () =>
            {
                OnButtonRemoveFromGroupClicked(index_filtered);
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

            Transform childObject_buttonLeaveGroup = AllFriendsButtons[index_all].transform.Find("ButtonLeaveGroup");
            Button buttonLeaveGroup = childObject_buttonLeaveGroup.GetComponent<Button>();

            Transform childObject_buttonRemoveFromGroup = AllFriendsButtons[index_all].transform.Find("ButtonRemoveFromGroup");
            Button buttonRemoveFromGroup = childObject_buttonRemoveFromGroup.GetComponent<Button>();

            Transform childObject_buttonChat = AllFriendsButtons[index_all].transform.Find("Chat");
            Button buttonChat = childObject_buttonChat.GetComponent<Button>();

            childObject_buttonLeaveGroup.gameObject.SetActive(false);
            childObject_buttonRemoveFromGroup.gameObject.SetActive(false);
            childObject_buttonChat.gameObject.SetActive(false);

            if (GetMyGroupResponse.IsGroupOwner)
            {
                buttonRemoveFromGroup.onClick.RemoveAllListeners();
                buttonRemoveFromGroup.onClick.AddListener(MakeOnButtonRemoveFromGroupClicked(index_filtered));
                childObject_buttonRemoveFromGroup.gameObject.SetActive(true);
            }
            else if (GetMyGroupResponse.IsGroupMember)
            {
                if (user.UserId == Gaos.Context.Authentication.GetUserId())
                {
                    buttonLeaveGroup.onClick.RemoveAllListeners();
                    buttonLeaveGroup.onClick.AddListener(MakeOnButtonLeaveGroupClicked(index_filtered));
                    childObject_buttonLeaveGroup.gameObject.SetActive(true);
                }
            }

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


        public void RemoveAllFriendsButtons()
        {
            foreach (Transform child in List)
            {
                GameObject.Destroy(child.gameObject);
            }
            LastIndexAllFriendsButtons = -1;
        }


        public void OnSearchTextBoxChange(string text)
        {
            Debug.Log($"@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@ cp 455: OnSearchTextBoxChange(): {text}");
            FilterUsers(text);
            DisplayFilteredUsers();
            DisplayTitle();
        }

        private void InitAll()
        {
            RemoveAllFriendsButtons();
            Init().Forget();
        }

        public void OnEnable()
        {
            InitAll();
        }

        public void OnDisable()
        {
            UpdateUnreadMessagesCountsLoop_IsFinished = true;
            if (UpdateUnreadMessagesCountsLoop_CancellationTokenSource != null)
            {
                UpdateUnreadMessagesCountsLoop_CancellationTokenSource.Cancel();
            }

        }

        public void DisplayTitle()
        {
            Title.SetActive(true);
            LeaveGroupDialog.SetActive(false);
            RemoveFromGroupDialog.SetActive(false);
        }



        public async UniTaskVoid OnButtonLeaveFromGroupYesAsync()
        {
            var response = await Gaos.Groups.Groups.LeaveGroup.CallAsync();
            if (response == null)
            {
                // error occured
                return;
            }
            else
            {
                // success
            }
        }

        public void OnButtonLeaveFromGroupYes()
        {
            Debug.Log($"@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@ cp 910: OnButtonLeaveFromGroupYes()");
            OnButtonLeaveFromGroupYesAsync().Forget();


            GetMyGroupResponse.IsGroupMember = false;
            SetTitleText();
            DisplayTitle();

            LastIndexAllUsers = -1;
            AllocateFriendsButtons();
            LastIndexFilteredUsers = -1;
            DisplayFilteredUsers();

            // readraw all to ensure thatr display reflects the server state
            InitAll();
        }

        public void OnButtonLeaveFromGroupNo()
        {
            DisplayTitle();
        }

        public void DisplayLeaveGroupDialog()
        {
            LeaveGroupDialogText.text = State_LeaveGroupDialog_message;

            Title.SetActive(false);
            LeaveGroupDialog.SetActive(true);
            RemoveFromGroupDialog.SetActive(false);
        }

        public async UniTaskVoid OnButtonRemoveFromGroupYesAsync()
        {
            int index_all = FilteredUsers[State_RemoveFromGroupDialog_index_filtered];
            FriendModel user = AllUsers[index_all];
            var response = await Gaos.Groups.Groups.RemoveFromGroup.CallAsync(user.UserId);
            if (response == null)
            {
                // error occured
                return;
            }
        }

        public void OnButtonRemoveFromGroupYes()
        {
            Debug.Log($"@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@ cp 910: OnButtonRemoveFromGroupYes()");
            Debug.Log($"@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@ cp 920: {State_RemoveFromGroupDialog_index_filtered}");
            OnButtonRemoveFromGroupYesAsync().Forget();

            int index_all = FilteredUsers[State_RemoveFromGroupDialog_index_filtered];

            DisplayTitle();

            FriendModel user = AllUsers[index_all];
            user.Gui_IsLineVisible = false;
            DisplayFilteredUsers();

            // readraw all to ensure thatr display reflects the server state
            InitAll();
        }

        public void OnButtonRemoveFromGroupNo()
        {
            DisplayTitle();
        }

        public void DisplayRemoveFromGroupDialog()
        {
            RemoveFriomGroupDialogText.text = State_RemoveFromGroupDialog_message;

            Title.SetActive(false);
            LeaveGroupDialog.SetActive(false);
            RemoveFromGroupDialog.SetActive(true);
        }

        private async UniTask OnGroupChatButtonClickAsync()
        {
            Gaos.Routes.Model.ChatRoomJson.GetGroupChatRoomResponse responseChatRoom = await Gaos.ChatRoom.ChatRoom.GetGroupChatRoom.CallAsync();
            if (responseChatRoom == null)
            {
                return;
            }
            Debug.Log($"@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@ cp 500: chatroom name: {responseChatRoom.ChatRoomName}");
            messageList.SetChatRoomName(responseChatRoom.ChatRoomName);
            chatTab.SetActive(true);
        }

        public void OnGroupChatButtonClick()
        {
            OnGroupChatButtonClickAsync().Forget();

        }

        public async UniTask UpdateUnreadMessagesCounts()
        {
            const string METHOD_NAME = "UpdateUnreadMessagesCounts";

            if (LastIndexFilteredUsers < 0)
                return;
            
            for (int i = 0; i <= LastIndexFilteredUsers; i++)
            {
                int indexAll = FilteredUsers[i];
                FriendModel user = AllUsers[indexAll];

                Gaos.Routes.Model.ChatRoomJson.GetUserToFriendChatRoomResponse chatRoomResponse =
                    await Gaos.ChatRoom.ChatRoom.GetUserToFriendChatRoom.CallAsync(user.UserId);
                if (chatRoomResponse == null)
                {
                    Debug.Log($"{CLASS_NAME}:{METHOD_NAME} Failed to get chat room for friend {user.UserName}");
                    continue;
                }
                int chatRoomId = (int)chatRoomResponse.ChatRoomId;

                Gaos.Routes.Model.ChatRoomJson.GetUnreadMessagesCountResponse unreadResponse =
                    await Gaos.ChatRoom.ChatRoom.GetUnreadMessagesCount.CallAsync(chatRoomId, Gaos.Context.Authentication.GetUserId());
                if (unreadResponse == null)
                {
                    Debug.Log($"{CLASS_NAME}:{METHOD_NAME}: ERROR: Failed to get unread message count for friend {user.UserName}");
                }
                int unreadCount = unreadResponse.count;

                int index_filtered = 0;
                if (!UserToFilteredUsersIndex.TryGetValue(user.UserId, out index_filtered))
                {
                    Debug.LogWarning($"{CLASS_NAME}:{METHOD_NAME}: could not get index_filtered for userId");
                    continue;
                }
                int index = 0;
                if (index_filtered < 0 || index_filtered > LastIndexFilteredUsers)
                {
                    Debug.LogWarning($"{CLASS_NAME}:{METHOD_NAME}: index_filtered out of range");
                    continue;
                }
                index = FilteredUsers[index_filtered];
                if (index < 0 || index > LastIndexAllFriendsButtons)
                {
                    Debug.LogWarning($"{CLASS_NAME}:{METHOD_NAME}: index out of range");
                    continue;
                }
                GameObject friendButton = AllFriendsButtons[index];
                if (friendButton == null)
                {
                    Debug.LogWarning($"{CLASS_NAME}:{METHOD_NAME}: friendButton is null");
                    continue;
                }
                Transform unreadCountTransform = friendButton.transform.Find("Chat/UnreadCount");
                if (unreadCountTransform != null)
                {
                    TextMeshProUGUI unreadCountText = unreadCountTransform.GetComponent<TextMeshProUGUI>();
                    if (unreadCountText != null)
                    {
                        unreadCountText.text = unreadCount > 0 ? unreadCount.ToString() : "";
                    }
                    else
                    {
                        Debug.LogWarning($"{CLASS_NAME}:{METHOD_NAME}: unreadCountText is null");
                    }
                }
                else
                {
                    Debug.LogWarning($"{CLASS_NAME}:{METHOD_NAME}: unreadCountTransform is null");
                }
            }
        }

        private bool UpdateUnreadMessagesCountsLoop_IsFinished = false;
        private System.Threading.CancellationTokenSource UpdateUnreadMessagesCountsLoop_CancellationTokenSource;  

        private async UniTaskVoid UpdateUnreadMessagesCountsLoop()
        {
            const string METHOD_NAME = "UpdateUnreadMessagesCountsLoop()";

            UpdateUnreadMessagesCountsLoop_CancellationTokenSource = new System.Threading.CancellationTokenSource();
            UpdateUnreadMessagesCountsLoop_IsFinished = false;

            while (true)
            {
                if (UpdateUnreadMessagesCountsLoop_IsFinished)
                {
                    break;
                }

                await UpdateUnreadMessagesCounts();


                // sleep
                try
                {
                    await UniTask.Delay(System.TimeSpan.FromSeconds(1), ignoreTimeScale: false, PlayerLoopTiming.Update, UpdateUnreadMessagesCountsLoop_CancellationTokenSource.Token);
                }
                catch (System.OperationCanceledException)
                {
                    if (UpdateUnreadMessagesCountsLoop_IsFinished)
                    {
                        break;
                    }
                }
            }
        }
    }


}

