﻿using System.Collections;
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
    public class FriendModel
    {
        public string UserName { get; set; }
        public int UserId { get; set; }
        public bool Gui_IsLineVisible { get; set; }
    }

    public class FriendsGroupTabManager : MonoBehaviour
    {
        private static string CLASS_NAME = typeof(FriendsGroupTabManager).Name;

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

        private string State_RemoveFromGroupDialog_message; 
        private int State_RemoveFromGroupDialog_index_filtered; 


        //public GameObject SearchTextBox;
        public TMP_InputField SearchTextBox;

        private FriendModel[] AllUsers = new FriendModel[MAX_SCROLL_LIST_LINES_COUNT]; 
        private int LastIndexAllUsers = -1;

        private int[] FilteredUsers = new int[MAX_SCROLL_LIST_LINES_COUNT];
        private int LastIndexFilteredUsers = -1;

        private GameObject[] AllFriendsButtons = new GameObject[MAX_SCROLL_LIST_LINES_COUNT]; // all friends buttons in the scroll list
        private int LastIndexAllFriendsButtons = -1;

        Gaos.Routes.Model.GroupJson.GetMyGroupResponse GetMyGroupResponse;

        FriendsGroupTabManager()
        {
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
            if (GetMyGroupResponse.IsGroupOwner)
            {
                string message =  "My Group";
                switch(Application.systemLanguage)
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
                string message =  $"Group - {GetMyGroupResponse.GroupOwnerName}";
                switch(Application.systemLanguage)
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
                string message =  "No Group";
                switch(Application.systemLanguage)
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

        private async UniTaskVoid Init()
        {
            bool isOnSearchTextBoxChange = false;

            // get my group

            GetMyGroupResponse = await Gaos.Groups.Groups.GetMyGroup.CallAsync();
            if (GetMyGroupResponse == null)
            {
                return;
            }
            SetTitleText();

            await GuiReadAllUsersList();

            if (!isOnSearchTextBoxChange)
            {
                SearchTextBox.onValueChanged.AddListener(OnSearchTextBoxChange);
            }

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

        private UnityAction  MakeOnButtonLeaveGroupClicked(int index_filtered)
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

        private UnityAction  MakeOnButtonRemoveFromGroupClicked(int index_filtered)
        {
            return () =>
            {
                OnButtonRemoveFromGroupClicked(index_filtered);
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

            childObject_buttonLeaveGroup.gameObject.SetActive(false);
            childObject_buttonRemoveFromGroup.gameObject.SetActive(false);

            if (GetMyGroupResponse.IsGroupOwner)
            {
                buttonRemoveFromGroup.onClick.AddListener(MakeOnButtonRemoveFromGroupClicked(index_filtered));
                childObject_buttonRemoveFromGroup.gameObject.SetActive(true);
            }
            else if (GetMyGroupResponse.IsGroupMember)
            {
                if (user.UserId == Gaos.Context.Authentication.GetUserId())
                {
                    buttonLeaveGroup.onClick.AddListener(MakeOnButtonLeaveGroupClicked(index_filtered));
                    childObject_buttonLeaveGroup.gameObject.SetActive(true);
                }
            }

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

        public void OnEnable()
        {
            RemoveAllFriendsButtons();
            SearchTextBox.text = ""; 
            Init().Forget();
        }

        public void OnDisable()
        {
            SearchTextBox.onValueChanged.RemoveListener(OnSearchTextBoxChange);

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
        }

        public void OnButtonRemoveFromGroupNo() {
            DisplayTitle();
        }

        public void DisplayRemoveFromGroupDialog()
        {
            RemoveFriomGroupDialogText.text = State_RemoveFromGroupDialog_message;

            Title.SetActive(false);
            LeaveGroupDialog.SetActive(false);
            RemoveFromGroupDialog.SetActive(true);
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

