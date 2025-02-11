using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Events;
using Cysharp.Threading.Tasks;
using System;
using Cysharp.Threading.Tasks.CompilerServices;

namespace Friends
{
    public class FriendRequestModel
    {
        public int GroupId { get; set; }
        public int GroupOwnerId { get; set; }
        public string GroupOwnerName { get; set; }

        public bool IsAccepted { get; set; }
        public bool IsRejected { get; set; }
    }

    public class FriendsGroupTabFriendsRequestsManager : MonoBehaviour
    {
        private static string CLASS_NAME = typeof(FriendsGroupTabFriendsRequestsManager).Name;

        // Maximum number of lines to be displayed in the scroll list.
        private static int MAX_SCROLL_LIST_LINES_COUNT = 10;

        public GameObject FriendsButton;
        public Transform List; // scroll list containing friend request buttons

        public TMP_InputField SearchTextBox;

        private FriendRequestModel[] AllRequests = new FriendRequestModel[MAX_SCROLL_LIST_LINES_COUNT]; 
        private int LastIndexAllRequests = -1;

        private int[] FilteredRequessts = new int[MAX_SCROLL_LIST_LINES_COUNT];
        private int LastIndexFilteredUsers = -1;

        private GameObject[] AllRequestsButtons = new GameObject[MAX_SCROLL_LIST_LINES_COUNT]; // all friend request buttons in the scroll list
        private int LastIndexAllRequestsButtons = -1;

        public GameObject MultiplayerGroupTab;

        FriendsGroupTabFriendsRequestsManager()
        {
        }

        private async UniTaskVoid Init()
        {
            bool isOnSearchTextBoxChange = false;

            RemoveAllFriendRequestButtons();
            await ReadAllRequests();
            AllocateFriendRequestButtons();
            FilterRequests("");
            DisplayFilteredRequests();

            if (!isOnSearchTextBoxChange)
            {
                SearchTextBox.onValueChanged.AddListener(OnSearchTextBoxChange);
            }
        }

        private async UniTask ReadAllRequests(string frienNameSubstring = null)
        {
            Gaos.Routes.Model.GroupJson.GetFriendRequestsResponse response = await Gaos.Groups.Groups.GetFriendRequests.CallAsync(MAX_SCROLL_LIST_LINES_COUNT, frienNameSubstring);
            if (response == null)
            {
                // error occurred
                return; 
            }
            LastIndexAllRequests = -1;
            if (response == null)
            {
                return; 
            }

            for (int i = 0; i < response.FriendRequests.Count; i++)
            {
                // Fill in requests array
                AllRequests[++LastIndexAllRequests] = new FriendRequestModel {
                    GroupId = response.FriendRequests[i].GroupId,
                    GroupOwnerId = response.FriendRequests[i].GroupOwnerId,
                    GroupOwnerName = response.FriendRequests[i].GroupOwnerName,
                    IsAccepted = false,
                    IsRejected = false  
                };

                // Limit the maximal number of displayed items
                if (i + 1 == MAX_SCROLL_LIST_LINES_COUNT)
                {
                    break;
                }
            }
        }

        private async UniTaskVoid AcceptFriendRequestAsync(int groupId)
        {
            Gaos.Routes.Model.GroupJson.AcceptFriendRequestResponse response = await Gaos.Groups.Groups.AcceptFriendRequest.CallAsync(groupId);
            if (response == null)
            {
                // error occurred
                return;
            }
            else
            {
                // display group tab
                gameObject.SetActive(false);
                MultiplayerGroupTab.SetActive(true);
                Animator animator = MultiplayerGroupTab.GetComponent<Animator>();
                animator.Play("Window In");
            }
        }

        // Modified: When the user accepts a friend request, remove all displayed requests.
        private void OnButtonAcceptClicked(int index)
        {
            Debug.Log($"@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@ cp 300: OnButtonAcceptClicked({index})");

            int index_all = FilteredRequessts[index];
            FriendRequestModel friendRequest = AllRequests[index_all];
            friendRequest.IsAccepted = true;

            // Call the asynchronous acceptance request.
            AcceptFriendRequestAsync(friendRequest.GroupId).Forget();

            // Clear all friend requests from the display.
            ClearAllFriendRequests();

        }

        private UnityAction MakeOnButtonAcceptClicked(int index)
        {
            return () =>
            {
                OnButtonAcceptClicked(index);
            };
        }

        private async UniTaskVoid RejectFriendRequestAsync(int groupId)
        {
            Gaos.Routes.Model.GroupJson.RejectFriendRequestResponse response = await Gaos.Groups.Groups.RejectFriendRequest.CallAsync(groupId);
            if (response == null)
            {
                // error occurred
                return; 
            }
        }

        private void OnButtonRejectClicked(int index)
        {
            Debug.Log($"@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@ cp 300: OnButtonRejectClicked({index})");

            int index_all = FilteredRequessts[index];
            FriendRequestModel friendRequest = AllRequests[index_all];
            friendRequest.IsRejected = true;

            RejectFriendRequestAsync(friendRequest.GroupId).Forget();
            DisplayRequestButton(index);
        }

        private UnityAction MakeOnButtonRejectClicked(int index)
        {
            return () =>
            {
                OnButtonRejectClicked(index);
            };
        }

        private void AllocateFriendRequestButtons()
        {
            int n = (LastIndexAllRequests + 1) - (LastIndexAllRequestsButtons + 1);
            while (n > 0)
            {
                GameObject friendsButton = Instantiate(FriendsButton, List);
                friendsButton.transform.position = Vector3.zero;
                friendsButton.SetActive(false);
                AllRequestsButtons[++LastIndexAllRequestsButtons] = friendsButton;
                --n;

                // Add onClick handler to ButtonAccept.
                Transform transformButtonAdd = friendsButton.transform.Find("ButtonAccept");
                if (transformButtonAdd == null)
                {
                    Debug.LogWarning($"ButtonAccept not found");
                }
                else
                {
                    Button buttonAccept = transformButtonAdd.GetComponent<Button>();
                    if (buttonAccept == null)
                    {
                        Debug.LogWarning($"ButtonAccept not found");
                    }
                    else
                    {
                        buttonAccept.onClick.AddListener(MakeOnButtonAcceptClicked(LastIndexAllRequestsButtons));
                    }
                }

                // Add onClick handler to ButtonReject.
                Transform transformButtonReject = friendsButton.transform.Find("ButtonReject");
                if (transformButtonReject == null)
                {
                    Debug.LogWarning($"ButtonReject not found");
                }
                else
                {
                    Button buttonReject = transformButtonReject.GetComponent<Button>();
                    if (buttonReject == null)
                    {
                        Debug.LogWarning($"ButtonReject not found");
                    }
                    else
                    {
                        buttonReject.onClick.AddListener(MakeOnButtonRejectClicked(LastIndexAllRequestsButtons));
                    }
                }
            }
        }
        
        private void FilterRequests(string substring)
        {
            LastIndexFilteredUsers = -1;

            for (int i = 0; i <= LastIndexAllRequests; i++)
            {
                if (string.IsNullOrEmpty(substring) || AllRequests[i].GroupOwnerName.Contains(substring))
                {
                    FilteredRequessts[++LastIndexFilteredUsers] = i;
                }
            }
        }

        private void DisplayRequestButton(int index_filtered)
        { 
            int index_all = FilteredRequessts[index_filtered];
            FriendRequestModel friendRequest = AllRequests[index_all];

            Transform childObject_friendUsername = AllRequestsButtons[index_all].transform.Find("Info/FriendUsername");
            TextMeshProUGUI friendUsername = childObject_friendUsername.GetComponent<TextMeshProUGUI>();
            friendUsername.text = friendRequest.GroupOwnerName;

            Transform childObject_InfoStatus = AllRequestsButtons[index_all].transform.Find("InfoStatus");
            GameObject gameObject_InfoStatus = childObject_InfoStatus.gameObject;

            Transform childObject_InfoStatus_Text = AllRequestsButtons[index_all].transform.Find("InfoStatus/Text");
            GameObject gameObject_InfoStatus_Text = childObject_InfoStatus_Text.gameObject;

            Transform childObject_ButtonAccept = AllRequestsButtons[index_all].transform.Find("ButtonAccept");
            GameObject gameObject_ButtonAccept = childObject_ButtonAccept.gameObject;

            Transform childObject_ButtonReject = AllRequestsButtons[index_all].transform.Find("ButtonReject");  
            GameObject gameObject_ButtonReject = childObject_ButtonReject.gameObject;

            gameObject_InfoStatus.SetActive(false);
            gameObject_ButtonAccept.SetActive(false);
            gameObject_ButtonReject.SetActive(false);

            if (friendRequest.IsAccepted)
            {
                gameObject_InfoStatus.SetActive(true);
                TextMeshProUGUI infoStatusText = gameObject_InfoStatus_Text.GetComponent<TextMeshProUGUI>();
                {
                    string message = "Accepted";
                    // Translate message based on system language.
                    switch (Application.systemLanguage)
                    {
                        case SystemLanguage.English:
                            message = "Accepted";
                            break;
                        case SystemLanguage.Russian:
                            message = "Принято";
                            break;
                        case SystemLanguage.Chinese:
                            message = "已接受";
                            break;
                        case SystemLanguage.Slovak:
                            message = "Prijaté";
                            break;
                        default:
                            message = "Accepted";
                            break;
                    }
                    infoStatusText.text = message;
                }
            }
            else if (friendRequest.IsRejected)
            {
                gameObject_InfoStatus.SetActive(true);
                TextMeshProUGUI infoStatusText = gameObject_InfoStatus_Text.GetComponent<TextMeshProUGUI>();
                {
                    string message = "Rejected";
                    // Translate message based on system language.
                    switch (Application.systemLanguage)
                    {
                        case SystemLanguage.English:
                            message = "Rejected";
                            break;
                        case SystemLanguage.Russian:
                            message = "Отклонено";
                            break;
                        case SystemLanguage.Chinese:
                            message = "已拒绝";
                            break;
                        case SystemLanguage.Slovak:
                            message = "Odmietnuté";
                            break;
                        default:
                            message = "Rejected";
                            break;
                    }
                    infoStatusText.text = message;
                }
            }
            else
            {
                gameObject_ButtonAccept.SetActive(true);
                gameObject_ButtonReject.SetActive(true);
            }
        }

        private void DisplayFilteredRequests()
        {
            for (int i = 0; i <= LastIndexFilteredUsers; i++)
            {
                int index = FilteredRequessts[i];
                FriendRequestModel friendRequest = AllRequests[index];

                AllRequestsButtons[i].SetActive(true);
                DisplayRequestButton(i);
            }

            for (int i = LastIndexFilteredUsers + 1; i <= LastIndexAllRequestsButtons; i++)
            {
                AllRequestsButtons[i].SetActive(false);
            }
        }

        public void RemoveAllFriendRequestButtons()
        {
            foreach (Transform child in List)
            {
                GameObject.Destroy(child.gameObject);
            }
            LastIndexAllRequestsButtons = -1;
        }

        public void OnSearchTextBoxChange(string text)
        {
            Debug.Log($"@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@ cp 455: OnSearchTextBoxChange(): {text}");
            FilterRequests(text);
            DisplayFilteredRequests();
        }

        public void OnEnable()
        {
            RemoveAllFriendRequestButtons();
            SearchTextBox.text = "";
            Init().Forget();
        }

        public void OnDisable()
        {
            SearchTextBox.onValueChanged.RemoveListener(OnSearchTextBoxChange);
        }

        private async UniTask GuiReadAllUsersList(string userNamePattern)
        {
            RemoveAllFriendRequestButtons();
            await ReadAllRequests(userNamePattern);
            AllocateFriendRequestButtons();
            FilterRequests("");
            DisplayFilteredRequests();
        }

        private async UniTaskVoid OnSearchIconClickAsync(string userNamePattern)
        {
            await GuiReadAllUsersList(userNamePattern);
        }

        public void OnSearchIconClick()
        {
            Debug.Log($"@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@ cp 400: OnSearchIconClick(): {SearchTextBox.text}");
            OnSearchIconClickAsync(SearchTextBox.text).Forget();
        }

        // New helper method to clear all friend requests from the displayed list.
        private void ClearAllFriendRequests()
        {
            LastIndexAllRequests = -1;
            LastIndexFilteredUsers = -1;
            RemoveAllFriendRequestButtons();
        }
    }
}
