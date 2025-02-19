using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cysharp.Threading.Tasks;
using Newtonsoft.Json;
using UnityEngine;

namespace Gaos.Friends
{
    public class GetUsersForFriendsSearch
    {
        public readonly static string CLASS_NAME = typeof(GetUsersForFriendsSearch).Name;

        public static async UniTask<Gaos.Routes.Model.FriendJson.GetUsersForFriendsSearchResponse> CallAsync(string filterUserName, int maxCount)
        {
            const string METHOD_NAME = "api/friends/getUsersForFriendsSearch";
            try
            {
                Gaos.Routes.Model.FriendJson.GetUsersForFriendsSearchRequest request = new Gaos.Routes.Model.FriendJson.GetUsersForFriendsSearchRequest();
                request.UserNamePattern = filterUserName;
                request.MaxCount = maxCount;
                string requestJsonStr = JsonConvert.SerializeObject(request);
                Gaos.Api.ApiCall apiCall = new Gaos.Api.ApiCall("api/friends/getUsersForFriendsSearch", requestJsonStr);
                await apiCall.CallAsync();
                if (apiCall.IsResponseError)
                {
                    Debug.LogWarning($"{CLASS_NAME}:{METHOD_NAME}: ERROR: error getting users list");
                    return null;
                }
                else
                {
                    Gaos.Routes.Model.FriendJson.GetUsersForFriendsSearchResponse response = JsonConvert.DeserializeObject<Gaos.Routes.Model.FriendJson.GetUsersForFriendsSearchResponse>(apiCall.ResponseJsonStr);
                    if (response.IsError == true)
                    {
                        Debug.LogWarning($"{CLASS_NAME}:{METHOD_NAME}: ERROR: error getting users list: {response.ErrorMessage}");
                        return null;
                    }
                    return response;
                }
            }
            catch (System.Exception ex)
            {
                Debug.LogError($"{CLASS_NAME}:{METHOD_NAME}: ERROR: {ex.Message}");
                return null;
            }
        }
    }

    public class RequestFriend
    {
        public readonly static string CLASS_NAME = typeof(RequestFriend).Name;

        public static async UniTask<Gaos.Routes.Model.FriendJson.RequestFriendResponse> CallAsync(int friendUserId)
        {
            const string METHOD_NAME = "api/friends/requestFriend";
            try
            {
                Gaos.Routes.Model.FriendJson.RequestFriendRequest request = new Gaos.Routes.Model.FriendJson.RequestFriendRequest();
                request.UserId = friendUserId;
                string requestJsonStr = JsonConvert.SerializeObject(request);
                Gaos.Api.ApiCall apiCall = new Gaos.Api.ApiCall("api/friends/requestFriend", requestJsonStr);
                await apiCall.CallAsync();
                if (apiCall.IsResponseError)
                {
                    Debug.LogWarning($"{CLASS_NAME}:{METHOD_NAME}: ERROR: error requesting friend");
                    return null;
                }
                else
                {
                    Gaos.Routes.Model.FriendJson.RequestFriendResponse response = JsonConvert.DeserializeObject<Gaos.Routes.Model.FriendJson.RequestFriendResponse>(apiCall.ResponseJsonStr);
                    if (response.IsError == true)
                    {
                        Debug.LogWarning($"{CLASS_NAME}:{METHOD_NAME}: ERROR: error requesting friend: {response.ErrorMessage}");
                        return null;
                    }
                    return response;
                }
            }
            catch (System.Exception ex)
            {
                Debug.LogError($"{CLASS_NAME}:{METHOD_NAME}: ERROR: {ex.Message}");
                return null;
            }
        }
    }

    public class RemoveFriend
    {
        public readonly static string CLASS_NAME = typeof(RemoveFriend).Name;

        public static async UniTask<Gaos.Routes.Model.FriendJson.RemoveFriendResponse> CallAsync(int friendUserId)
        {
            const string METHOD_NAME = "api/friends/removeFriend";
            try
            {
                Gaos.Routes.Model.FriendJson.RemoveFriendRequest request = new Gaos.Routes.Model.FriendJson.RemoveFriendRequest();
                request.UserId = friendUserId;
                string requestJsonStr = JsonConvert.SerializeObject(request);
                Gaos.Api.ApiCall apiCall = new Gaos.Api.ApiCall("api/friends/removeFriend", requestJsonStr);
                await apiCall.CallAsync();
                if (apiCall.IsResponseError)
                {
                    Debug.LogWarning($"{CLASS_NAME}:{METHOD_NAME}: ERROR: error removing friend");
                    return null;
                }
                else
                {
                    Gaos.Routes.Model.FriendJson.RemoveFriendResponse response = JsonConvert.DeserializeObject<Gaos.Routes.Model.FriendJson.RemoveFriendResponse>(apiCall.ResponseJsonStr);
                    if (response.IsError == true)
                    {
                        Debug.LogWarning($"{CLASS_NAME}:{METHOD_NAME}: ERROR: error removing friend: {response.ErrorMessage}");
                        return null;
                    }
                    return response;
                }
            }
            catch (System.Exception ex)
            {
                Debug.LogError($"{CLASS_NAME}:{METHOD_NAME}: ERROR: {ex.Message}");
                return null;
            }
        }
    }

    public class GetMyFriends
    {
        public readonly static string CLASS_NAME = typeof(GetMyFriends).Name;
        public static async UniTask<Gaos.Routes.Model.FriendJson.GetMyFriendsResponse> CallAsync(string userNamePattern, int maxCount)
        {
            const string METHOD_NAME = "api/friends/getMyFriends";
            try
            {
                Gaos.Routes.Model.FriendJson.GetMyFriendsRequest request = new Gaos.Routes.Model.FriendJson.GetMyFriendsRequest();
                request.UserNamePattern = userNamePattern;
                request.MaxCount = maxCount;
                string requestJsonStr = JsonConvert.SerializeObject(request);
                Gaos.Api.ApiCall apiCall = new Gaos.Api.ApiCall("api/friends/getMyFriends", requestJsonStr);
                await apiCall.CallAsync();
                if (apiCall.IsResponseError)
                {
                    Debug.LogWarning($"{CLASS_NAME}:{METHOD_NAME}: ERROR: error getting my friends");
                    return null;
                }
                else
                {
                    Gaos.Routes.Model.FriendJson.GetMyFriendsResponse response = JsonConvert.DeserializeObject<Gaos.Routes.Model.FriendJson.GetMyFriendsResponse>(apiCall.ResponseJsonStr);
                    if (response.IsError == true)
                    {
                        Debug.LogWarning($"{CLASS_NAME}:{METHOD_NAME}: ERROR: error getting my friends: {response.ErrorMessage}");
                        return null;
                    }
                    return response;
                }
            }
            catch (System.Exception ex)
            {
                Debug.LogError($"{CLASS_NAME}:{METHOD_NAME}: ERROR: {ex.Message}");
                return null;
            }
        }
    }

    public class GetFriendRequests
    {
        public static readonly string CLASS_NAME = typeof(GetFriendRequests).Name;

        public static async UniTask<Gaos.Routes.Model.FriendJson.GetFriendRequestsResponse> CallAsync(int maxCount)
        {
            const string METHOD_NAME = "api/friends/getFriendRequests";
            try
            {
                var request = new Gaos.Routes.Model.FriendJson.GetFriendRequestsRequest
                {
                    MaxCount = maxCount
                };

                string requestJsonStr = JsonConvert.SerializeObject(request);

                Gaos.Api.ApiCall apiCall = new Gaos.Api.ApiCall("api/friends/getFriendRequests", requestJsonStr);
                await apiCall.CallAsync();

                if (apiCall.IsResponseError)
                {
                    Debug.LogWarning($"{CLASS_NAME}:{METHOD_NAME}: ERROR: error retrieving friend requests.");
                    return null;
                }
                else
                {
                    var response = JsonConvert.DeserializeObject<Gaos.Routes.Model.FriendJson.GetFriendRequestsResponse>(apiCall.ResponseJsonStr);

                    if (response.IsError == true)
                    {
                        Debug.LogWarning($"{CLASS_NAME}:{METHOD_NAME}: ERROR: {response.ErrorMessage}");
                        return null;
                    }

                    return response;
                }
            }
            catch (Exception ex)
            {
                Debug.LogError($"{CLASS_NAME}:{METHOD_NAME}: ERROR: {ex.Message}");
                return null;
            }
        }
    }

    public class GetCountOfFriendRequests
    {
        public static readonly string CLASS_NAME = typeof(GetCountOfFriendRequests).Name;

        public static async UniTask<Gaos.Routes.Model.FriendJson.GetCountOfFriendRequestsResponse> CallAsync()
        {
            const string METHOD_NAME = "api/friends/getCountOfFriendRequests";
            try
            {
                var request = new Gaos.Routes.Model.FriendJson.GetCountOfFriendRequestsRequest
                {
                };

                string requestJsonStr = JsonConvert.SerializeObject(request);

                Gaos.Api.ApiCall apiCall = new Gaos.Api.ApiCall("api/friends/getCountOfFriendRequests", requestJsonStr);
                await apiCall.CallAsync();

                if (apiCall.IsResponseError)
                {
                    Debug.LogWarning($"{CLASS_NAME}:{METHOD_NAME}: ERROR: error retrieving friend requests.");
                    return null;
                }
                else
                {
                    var response = JsonConvert.DeserializeObject<Gaos.Routes.Model.FriendJson.GetCountOfFriendRequestsResponse>(apiCall.ResponseJsonStr);

                    if (response.IsError == true)
                    {
                        Debug.LogWarning($"{CLASS_NAME}:{METHOD_NAME}: ERROR: {response.ErrorMessage}");
                        return null;
                    }

                    return response;
                }
            }
            catch (Exception ex)
            {
                Debug.LogError($"{CLASS_NAME}:{METHOD_NAME}: ERROR: {ex.Message}");
                return null;
            }
        }
    }

    public class AcceptFriendRequest
    {
        public readonly static string CLASS_NAME = typeof(AcceptFriendRequest).Name;

        public static async UniTask<Gaos.Routes.Model.FriendJson.FriendRequestAcceptResponse> CallAsync(int friendUserId)
        {
            const string METHOD_NAME = "api/friends/acceptFriendRequest";
            try
            {
                var request = new Gaos.Routes.Model.FriendJson.FriendRequestAcceptRequest
                {
                    UserId = friendUserId
                };

                string requestJsonStr = JsonConvert.SerializeObject(request);

                Gaos.Api.ApiCall apiCall = new Gaos.Api.ApiCall(METHOD_NAME, requestJsonStr);
                await apiCall.CallAsync();

                if (apiCall.IsResponseError)
                {
                    Debug.LogWarning($"{CLASS_NAME}:{METHOD_NAME}: ERROR: Error accepting friend request.");
                    return null;
                }
                else
                {
                    var response = JsonConvert.DeserializeObject<Gaos.Routes.Model.FriendJson.FriendRequestAcceptResponse>(apiCall.ResponseJsonStr);

                    if (response.IsError == true)
                    {
                        Debug.LogWarning($"{CLASS_NAME}:{METHOD_NAME}: ERROR: {response.ErrorMessage}");
                        return null;
                    }

                    return response;
                }
            }
            catch (Exception ex)
            {
                Debug.LogError($"{CLASS_NAME}:{METHOD_NAME}: ERROR: {ex.Message}");
                return null;
            }
        }
    }
}
