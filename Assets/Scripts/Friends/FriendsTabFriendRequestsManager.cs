using Cysharp.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Friends
{
    public class FriendsTabFriendRequestsManager : MonoBehaviour
    {
        public class FriendRequestModel
        {
            public string UserName { get; set; }
            public int    UserId   { get; set; }
        }

        private static string CLASS_NAME = typeof(FriendsTabFriendRequestsManager).Name;

        private static int MAX_REQUESTS_DISPLAY = 10;

        private FriendRequestModel[] allRequests = new FriendRequestModel[MAX_REQUESTS_DISPLAY];
        private int lastIndexAllRequests = -1;

        private int[] filteredRequestIndices = new int[MAX_REQUESTS_DISPLAY];
        private int lastIndexFilteredRequests = -1;

        public GameObject FriendsButton;
        public Transform List;

        private GameObject[] allFriendRequestButtons = new GameObject[MAX_REQUESTS_DISPLAY];
        private int lastIndexAllFriendRequestButtons = -1;

        public TMP_InputField SearchTextBox;


        void Start()
        {
        }

        void Update()
        {
        }

        public void OnEnable()
        {
            RemoveAllFriendRequestButtons();
            SearchTextBox.text = "";
            SearchTextBox.onValueChanged.AddListener(OnSearchTextBoxChange);

            Init().Forget();
        }

        public void OnDisable()
        {
            SearchTextBox.onValueChanged.RemoveListener(OnSearchTextBoxChange);
        }

        private async UniTaskVoid Init()
        {
            RemoveAllFriendRequestButtons();
            await ReadAllFriendRequests();
            AllocateFriendRequestButtons();

            FilterRequests("");
            DisplayFilteredRequests();
        }

        private void RemoveAllFriendRequestButtons()
        {
            foreach (Transform child in List)
            {
                GameObject.Destroy(child.gameObject);
            }
            lastIndexAllFriendRequestButtons = -1;
        }

        private async UniTask ReadAllFriendRequests()
        {
            var response = await Gaos.Friends.GetFriendRequests.CallAsync(MAX_REQUESTS_DISPLAY);

            if (response == null)
            {
                Debug.LogWarning($"{CLASS_NAME}:ReadAllFriendRequests() -> null response.");
                return;
            }

            lastIndexAllRequests = -1;

            for (int i = 0; i < response.FriendRequest.Length; i++)
            {
                var req = response.FriendRequest[i];

                allRequests[++lastIndexAllRequests] = new FriendRequestModel
                {
                    UserId   = req.UserId,
                    UserName = req.UserName
                };

                if (lastIndexAllRequests + 1 == MAX_REQUESTS_DISPLAY)
                    break;
            }
        }

        private void AllocateFriendRequestButtons()
        {
            const string METHOD_NAME = "AllocateFriendRequestButtons()";

            int numRequests = (lastIndexAllRequests + 1);
            int needed = numRequests - (lastIndexAllFriendRequestButtons + 1);

            while (needed > 0)
            {
                GameObject friendRequestButton = Instantiate(FriendsButton, List);
                friendRequestButton.transform.position = Vector3.zero;
                friendRequestButton.SetActive(false);  // We show it once we set data

                allFriendRequestButtons[++lastIndexAllFriendRequestButtons] = friendRequestButton;
                --needed;

                // Hook up "Add" (Accept)
                Transform transformButtonAdd = friendRequestButton.transform.Find("ButtonAdd");
                Button buttonAdd = transformButtonAdd.GetComponent<Button>();
                buttonAdd.onClick.AddListener(MakeOnButtonAddClicked(lastIndexAllFriendRequestButtons));

                // Hook up "Revoke" (Decline)
                Transform transformButtonRevoke = friendRequestButton.transform.Find("ButtonRevoke");
                Button buttonRevoke = transformButtonRevoke.GetComponent<Button>();
                buttonRevoke.onClick.AddListener(MakeOnButtonRevokeClicked(lastIndexAllFriendRequestButtons));
            }
        }

        private void OnSearchTextBoxChange(string text)
        {
            FilterRequests(text);
            DisplayFilteredRequests();
        }

        private void FilterRequests(string substring)
        {
            lastIndexFilteredRequests = -1;

            for (int i = 0; i <= lastIndexAllRequests; i++)
            {
                bool matches = false;
                if (string.IsNullOrEmpty(substring))
                {
                    matches = true; // No filter
                }
                else
                {
                    if (allRequests[i].UserName.Contains(substring))
                    {
                        matches = true;
                    }
                }

                if (matches)
                {
                    filteredRequestIndices[++lastIndexFilteredRequests] = i;
                    if (lastIndexFilteredRequests + 1 == MAX_REQUESTS_DISPLAY)
                    {
                        break;
                    }
                }
            }
        }

        private void DisplayFilteredRequests()
        {
            for (int i = 0; i <= lastIndexFilteredRequests; i++)
            {
                allFriendRequestButtons[i].SetActive(true);
                DisplayFriendRequestButton(i);
            }

            for (int i = lastIndexFilteredRequests + 1; i <= lastIndexAllFriendRequestButtons; i++)
            {
                allFriendRequestButtons[i].SetActive(false);
            }
        }

        private void DisplayFriendRequestButton(int uiIndex)
        {
            int actualIndex = filteredRequestIndices[uiIndex];
            var request = allRequests[actualIndex];
            var buttonObj = allFriendRequestButtons[uiIndex];

            // Friend Username label
            var friendUsernameLabel = buttonObj.transform.Find("Info/FriendUsername")?.GetComponent<TextMeshProUGUI>();
            friendUsernameLabel.text = request.UserName;

            // Friend Status label
            var friendStatusLabel = buttonObj.transform.Find("Info/Status")?.GetComponent<TextMeshProUGUI>();
            {
                var msg = "Friend request to me";
                switch (Application.systemLanguage)
                {
                    case SystemLanguage.English:
                        msg = "Friend request to me";
                        break;
                    case SystemLanguage.Russian:
                        msg = "Запрос в друзья мне";
                        break;
                    case SystemLanguage.Chinese:
                        msg = "朋友请求给我";
                        break;
                    case SystemLanguage.Slovak:
                        msg = "Žiadosť o priateľstvo mne";
                        break;
                    default:
                        msg = "Friend request to me";
                        break;
                }
                friendStatusLabel.text = msg;
            }

            var addButton = buttonObj.transform.Find("ButtonAdd").gameObject;
            var removeButton = buttonObj.transform.Find("ButtonRevoke").gameObject;
            addButton.SetActive(true);
            removeButton.SetActive(true);
        }

        private void OnButtonAddClicked(int uiIndex)
        {
            int actualIndex = filteredRequestIndices[uiIndex];
            var request = allRequests[actualIndex];

            Gaos.Friends.AcceptFriendRequest.CallAsync(request.UserId).Forget();
            RemoveFriendRequest(actualIndex);
        }

        private UnityAction MakeOnButtonAddClicked(int uiIndex)
        {
            return () => OnButtonAddClicked(uiIndex);
        }

        private void OnButtonRevokeClicked(int uiIndex)
        {
            int actualIndex = filteredRequestIndices[uiIndex];
            var request = allRequests[actualIndex];

            Gaos.Friends.RemoveFriend.CallAsync(request.UserId).Forget();
            RemoveFriendRequest(actualIndex);

        }

        private UnityAction MakeOnButtonRevokeClicked(int uiIndex)
        {
            return () => OnButtonRevokeClicked(uiIndex);
        }

        private void RemoveFriendRequest(int actualIndex)
        {
            for (int i = actualIndex; i < lastIndexAllRequests; i++)
            {
                allRequests[i] = allRequests[i + 1];
            }
            lastIndexAllRequests -= 1;
            FilterRequests(SearchTextBox.text);
            DisplayFilteredRequests();
        }
    }
}
