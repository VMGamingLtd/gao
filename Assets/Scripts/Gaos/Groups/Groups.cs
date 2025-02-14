using UnityEngine;
using Newtonsoft.Json;
using Cysharp.Threading.Tasks;

namespace Gaos.Groups.Groups
{

    public class GetUsersList
    {
        public readonly static string CLASS_NAME = typeof(GetUsersList).Name;

        public static async UniTask<Gaos.Routes.Model.GroupJson.GetUsersListResponse> CallAsync(string filterUserName, int maxCount)
        {
            const string METHOD_NAME = "api/groups/getUsersList";
            try
            {

                Gaos.Routes.Model.GroupJson.GetUsersListRequest request = new Gaos.Routes.Model.GroupJson.GetUsersListRequest();
                request.FilterUserName = filterUserName;
                request.MaxCount = maxCount;
                string requestJsonStr = JsonConvert.SerializeObject(request);
                Gaos.Api.ApiCall apiCall = new Gaos.Api.ApiCall("api/groups/getUsersList", requestJsonStr);
                await apiCall.CallAsync();
                if (apiCall.IsResponseError)
                {
                    Debug.LogWarning($"{CLASS_NAME}:{METHOD_NAME}: ERROR: error getting users list");
                    return null;
                }
                else
                {
                    Gaos.Routes.Model.GroupJson.GetUsersListResponse response = JsonConvert.DeserializeObject<Gaos.Routes.Model.GroupJson.GetUsersListResponse>(apiCall.ResponseJsonStr);
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

    public class AddFriend
    {
        public readonly static string CLASS_NAME = typeof(AddFriend).Name;


        public static async UniTask<Gaos.Routes.Model.GroupJson.AddFriendResponse> CallAsync(int userIdOfFriend)
        {
            const string METHOD_NAME = "api/groups/addFriend";
            try
            {

                Gaos.Routes.Model.GroupJson.AddFriendRequest request = new Gaos.Routes.Model.GroupJson.AddFriendRequest();
                request.UserId = userIdOfFriend;
                string requestJsonStr = JsonConvert.SerializeObject(request);
                Gaos.Api.ApiCall apiCall = new Gaos.Api.ApiCall("api/groups/addFriend", requestJsonStr);
                await apiCall.CallAsync();
                if (apiCall.IsResponseError)
                {
                    Debug.LogWarning($"{CLASS_NAME}:{METHOD_NAME}: ERROR: error adding friend");
                    return null;
                }
                else
                {
                    Gaos.Routes.Model.GroupJson.AddFriendResponse response = JsonConvert.DeserializeObject<Gaos.Routes.Model.GroupJson.AddFriendResponse>(apiCall.ResponseJsonStr);
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

    public class RevokeFriendRequest
    {
        public readonly static string CLASS_NAME = typeof(RevokeFriendRequest).Name;
        public static async UniTask<Gaos.Routes.Model.GroupJson.RevokeFriendRequestResponse> CallAsync(int userIdOfFriend)
        {
            const string METHOD_NAME = "api/groups/revokeFriendRequest";
            try
            {
                Gaos.Routes.Model.GroupJson.RevokeFriendRequestRequest request = new Gaos.Routes.Model.GroupJson.RevokeFriendRequestRequest();
                request.UserId = userIdOfFriend;
                string requestJsonStr = JsonConvert.SerializeObject(request);
                Gaos.Api.ApiCall apiCall = new Gaos.Api.ApiCall("api/groups/revokeFriendRequest", requestJsonStr);
                await apiCall.CallAsync();
                if (apiCall.IsResponseError)
                {
                    Debug.LogWarning($"{CLASS_NAME}:{METHOD_NAME}: ERROR: error revoking friend request");
                    return null;
                }
                else
                {
                    Gaos.Routes.Model.GroupJson.RevokeFriendRequestResponse response = JsonConvert.DeserializeObject<Gaos.Routes.Model.GroupJson.RevokeFriendRequestResponse>(apiCall.ResponseJsonStr);
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

    public class RemoveFromGroup
    {
        public readonly static string CLASS_NAME = typeof(RemoveFromGroup).Name;
        public static async UniTask<Gaos.Routes.Model.GroupJson.RemoveFromGroupResponse> CallAsync(int userIdOfFriend)
        {
            const string METHOD_NAME = "api/groups/removeFromGroup";
            try
            {
                Gaos.Routes.Model.GroupJson.RemoveFromGroupRequest request = new Gaos.Routes.Model.GroupJson.RemoveFromGroupRequest();
                request.UserId = userIdOfFriend;
                string requestJsonStr = JsonConvert.SerializeObject(request);
                Gaos.Api.ApiCall apiCall = new Gaos.Api.ApiCall("api/groups/removeFromGroup", requestJsonStr);
                await apiCall.CallAsync();
                if (apiCall.IsResponseError)
                {
                    Debug.LogWarning($"{CLASS_NAME}:{METHOD_NAME}: ERROR: error removing friend from group");
                    return null;
                }
                else
                {
                    Gaos.Routes.Model.GroupJson.RemoveFromGroupResponse response = JsonConvert.DeserializeObject<Gaos.Routes.Model.GroupJson.RemoveFromGroupResponse>(apiCall.ResponseJsonStr);
                    if (response.IsError == true)
                    {
                        Debug.LogWarning($"{CLASS_NAME}:{METHOD_NAME}: ERROR: error removing friend from group: {response.ErrorMessage}");
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

    public class LeaveGroup
    {
        public readonly static string CLASS_NAME = typeof(LeaveGroup).Name;
        public static async UniTask<Gaos.Routes.Model.GroupJson.LeaveGroupResponse> CallAsync()
        {
            const string METHOD_NAME = "api/groups/leaveGroup";
            try
            {
                Gaos.Routes.Model.GroupJson.LeaveGroupRequest request = new Gaos.Routes.Model.GroupJson.LeaveGroupRequest();
                string requestJsonStr = JsonConvert.SerializeObject(request);
                Gaos.Api.ApiCall apiCall = new Gaos.Api.ApiCall("api/groups/leaveGroup", requestJsonStr);
                await apiCall.CallAsync();
                if (apiCall.IsResponseError)
                {
                    Debug.LogWarning($"{CLASS_NAME}:{METHOD_NAME}: ERROR: error leaving group");
                    return null;
                }
                else
                {
                    Gaos.Routes.Model.GroupJson.LeaveGroupResponse response = JsonConvert.DeserializeObject<Gaos.Routes.Model.GroupJson.LeaveGroupResponse>(apiCall.ResponseJsonStr);
                    if (response.IsError == true)
                    {
                        Debug.LogWarning($"{CLASS_NAME}:{METHOD_NAME}: ERROR: error leaving group: {response.ErrorMessage}");
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
        public readonly static string CLASS_NAME = typeof(GetFriendRequests).Name;
        public static async UniTask<Gaos.Routes.Model.GroupJson.GetFriendRequestsResponse> CallAsync(int MaxCount, string OwnerNamePattern)
        {
            const string METHOD_NAME = "api/groups/getFriendRequests";
            try
            {
                Gaos.Routes.Model.GroupJson.GetFriendRequestsRequest request = new Gaos.Routes.Model.GroupJson.GetFriendRequestsRequest();
                request.MaxCount = MaxCount;
                request.IsCountOnly = false;
                if (OwnerNamePattern != null && OwnerNamePattern != "")
                {
                    request.OwnerNamePattern = OwnerNamePattern;
                }
                else
                {
                    request.OwnerNamePattern = null;
                }
                string requestJsonStr = JsonConvert.SerializeObject(request);
                Gaos.Api.ApiCall apiCall = new Gaos.Api.ApiCall("api/groups/getFriendRequests", requestJsonStr);
                await apiCall.CallAsync();
                if (apiCall.IsResponseError)
                {
                    Debug.LogWarning($"{CLASS_NAME}:{METHOD_NAME}: ERROR: error getting friend requests");
                    return null;
                }
                else
                {
                    Gaos.Routes.Model.GroupJson.GetFriendRequestsResponse response = JsonConvert.DeserializeObject<Gaos.Routes.Model.GroupJson.GetFriendRequestsResponse>(apiCall.ResponseJsonStr);
                    if (response.IsError == true)
                    {
                        Debug.LogWarning($"{CLASS_NAME}:{METHOD_NAME}: ERROR: error getting friend requests: {response.ErrorMessage}");
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

    public class GetFriendRequestsCount
    {
        public readonly static string CLASS_NAME = typeof(GetFriendRequestsCount).Name;
        public static async UniTask<int> CallAsync()
        {
            const string METHOD_NAME = "api/groups/getFriendRequests";
            try
            {
                Gaos.Routes.Model.GroupJson.GetFriendRequestsRequest request = new Gaos.Routes.Model.GroupJson.GetFriendRequestsRequest();
                request.IsCountOnly = true;
                string requestJsonStr = JsonConvert.SerializeObject(request);
                Gaos.Api.ApiCall apiCall = new Gaos.Api.ApiCall("api/groups/getFriendRequests", requestJsonStr);
                await apiCall.CallAsync();
                if (apiCall.IsResponseError)
                {
                    Debug.LogWarning($"{CLASS_NAME}:{METHOD_NAME}: ERROR: error getting friend requests");
                    return 0;
                }
                else
                {
                    Gaos.Routes.Model.GroupJson.GetFriendRequestsResponse response = JsonConvert.DeserializeObject<Gaos.Routes.Model.GroupJson.GetFriendRequestsResponse>(apiCall.ResponseJsonStr);
                    if (response.IsError == true)
                    {
                        Debug.LogWarning($"{CLASS_NAME}:{METHOD_NAME}: ERROR: error getting friend requests: {response.ErrorMessage}");
                        return 0;
                    }
                    return (int)response.TotalCount;
                }
            }
            catch (System.Exception ex)
            {
                Debug.LogError($"{CLASS_NAME}:{METHOD_NAME}: ERROR: {ex.Message}");
                return 0;
            }
        }
    }

    public class AcceptFriendRequest
    {
        public readonly static string CLASS_NAME = typeof(AcceptFriendRequest).Name;
        public static async UniTask<Gaos.Routes.Model.GroupJson.AcceptFriendRequestResponse> CallAsync(int groupId)
        {
            const string METHOD_NAME = "api/groups/acceptFriendRequest";
            try
            {
                Gaos.Routes.Model.GroupJson.AcceptFriendRequestRequest request = new Gaos.Routes.Model.GroupJson.AcceptFriendRequestRequest();
                request.GroupId = groupId;
                string requestJsonStr = JsonConvert.SerializeObject(request);
                Gaos.Api.ApiCall apiCall = new Gaos.Api.ApiCall("api/groups/acceptFriendRequest", requestJsonStr);
                await apiCall.CallAsync();
                if (apiCall.IsResponseError)
                {
                    Debug.LogWarning($"{CLASS_NAME}:{METHOD_NAME}: ERROR: error accepting friend request");
                    return null;
                }
                else
                {
                    Gaos.Routes.Model.GroupJson.AcceptFriendRequestResponse response = JsonConvert.DeserializeObject<Gaos.Routes.Model.GroupJson.AcceptFriendRequestResponse>(apiCall.ResponseJsonStr);
                    if (response.IsError == true)
                    {
                        Debug.LogWarning($"{CLASS_NAME}:{METHOD_NAME}: ERROR: error accepting friend request: {response.ErrorMessage}");
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

    public class RejectFriendRequest
    {
        public readonly static string CLASS_NAME = typeof(RejectFriendRequest).Name;
        public static async UniTask<Gaos.Routes.Model.GroupJson.RejectFriendRequestResponse> CallAsync(int groupId)
        {
            const string METHOD_NAME = "api/groups/rejectFriendRequest";
            try
            {
                Gaos.Routes.Model.GroupJson.RejectFriendRequestRequest request = new Gaos.Routes.Model.GroupJson.RejectFriendRequestRequest();
                request.GroupId = groupId;
                string requestJsonStr = JsonConvert.SerializeObject(request);
                Gaos.Api.ApiCall apiCall = new Gaos.Api.ApiCall("api/groups/rejectFriendRequest", requestJsonStr);
                await apiCall.CallAsync();
                if (apiCall.IsResponseError)
                {
                    Debug.LogWarning($"{CLASS_NAME}:{METHOD_NAME}: ERROR: error rejecting friend request");
                    return null;
                }
                else
                {
                    Gaos.Routes.Model.GroupJson.RejectFriendRequestResponse response = JsonConvert.DeserializeObject<Gaos.Routes.Model.GroupJson.RejectFriendRequestResponse>(apiCall.ResponseJsonStr);
                    if (response.IsError == true)
                    {
                        Debug.LogWarning($"{CLASS_NAME}:{METHOD_NAME}: ERROR: error rejecting friend request: {response.ErrorMessage}");
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

    public class GetMyGroup
    {
        public readonly static string CLASS_NAME = typeof(GetMyGroup).Name;

        public static async UniTask<Gaos.Routes.Model.GroupJson.GetMyGroupResponse> CallAsync()
        {
            const string METHOD_NAME = "api/groups/getMyGroup";
            try
            {
                Gaos.Routes.Model.GroupJson.GetMyGroupRequest request = new Gaos.Routes.Model.GroupJson.GetMyGroupRequest();
                string requestJsonStr = JsonConvert.SerializeObject(request);
                Gaos.Api.ApiCall apiCall = new Gaos.Api.ApiCall("api/groups/getMyGroup", requestJsonStr);
                await apiCall.CallAsync();
                if (apiCall.IsResponseError)
                {
                    Debug.LogWarning($"{CLASS_NAME}:{METHOD_NAME}: ERROR: error getting my group");
                    return null;
                }
                else
                {
                    Gaos.Routes.Model.GroupJson.GetMyGroupResponse response = JsonConvert.DeserializeObject<Gaos.Routes.Model.GroupJson.GetMyGroupResponse>(apiCall.ResponseJsonStr);
                    if (response.IsError == true)
                    {
                        Debug.LogWarning($"{CLASS_NAME}:{METHOD_NAME}: ERROR: error getting my group: {response.ErrorMessage}");
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

    public class GetMyGroupMembers
    {
        public readonly static string CLASS_NAME = typeof(GetMyGroupMembers).Name;

        public static async UniTask<Gaos.Routes.Model.GroupJson.GetMyGroupMembersResponse> CallAsync(int groupId, int maxCount)
        {
            const string METHOD_NAME = "api/groups/getMyGroupMembers";
            try
            {
                Gaos.Routes.Model.GroupJson.GetMyGroupMembersRequest request = new Gaos.Routes.Model.GroupJson.GetMyGroupMembersRequest();
                request.GroupId = groupId;
                request.MaxCount = maxCount;
                request.IsCountOnly = false;
                string requestJsonStr = JsonConvert.SerializeObject(request);
                Gaos.Api.ApiCall apiCall = new Gaos.Api.ApiCall("api/groups/getMyGroupMembers", requestJsonStr);
                await apiCall.CallAsync();
                if (apiCall.IsResponseError)
                {
                    Debug.LogWarning($"{CLASS_NAME}:{METHOD_NAME}: ERROR: error getting my group members");
                    return null;
                }
                else
                {
                    Gaos.Routes.Model.GroupJson.GetMyGroupMembersResponse response = JsonConvert.DeserializeObject<Gaos.Routes.Model.GroupJson.GetMyGroupMembersResponse>(apiCall.ResponseJsonStr);
                    if (response.IsError == true)
                    {
                        Debug.LogWarning($"{CLASS_NAME}:{METHOD_NAME}: ERROR: error getting my group members: {response.ErrorMessage}");
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

    public class GetMyGroupMembersCount
    {
        public readonly static string CLASS_NAME = typeof(GetMyGroupMembersCount).Name;

        public static async UniTask<int> CallAsync(int groupId)
        {
            const string METHOD_NAME = "api/groups/getMyGroupMembers";
            try
            {
                Gaos.Routes.Model.GroupJson.GetMyGroupMembersRequest request = new Gaos.Routes.Model.GroupJson.GetMyGroupMembersRequest();
                request.GroupId = groupId;
                request.IsCountOnly = true;
                string requestJsonStr = JsonConvert.SerializeObject(request);
                Gaos.Api.ApiCall apiCall = new Gaos.Api.ApiCall("api/groups/getMyGroupMembers", requestJsonStr);
                await apiCall.CallAsync();
                if (apiCall.IsResponseError)
                {
                    Debug.LogWarning($"{CLASS_NAME}:{METHOD_NAME}: ERROR: error getting my friends");
                    return 0;
                }
                else
                {
                    Gaos.Routes.Model.GroupJson.GetMyGroupMembersResponse response = JsonConvert.DeserializeObject<Gaos.Routes.Model.GroupJson.GetMyGroupMembersResponse>(apiCall.ResponseJsonStr);
                    if (response.IsError == true)
                    {
                        Debug.LogWarning($"{CLASS_NAME}:{METHOD_NAME}: ERROR: error getting my friends: {response.ErrorMessage}");
                        return 0;
                    }
                    return (int)response.TotalCount;
                }
            }
            catch (System.Exception ex)
            {
                Debug.LogError($"{CLASS_NAME}:{METHOD_NAME}: ERROR: {ex.Message}");
                return 0;
            }
        }

    }


}