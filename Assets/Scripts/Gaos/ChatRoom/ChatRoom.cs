
using UnityEngine;
using System.Collections;
using Newtonsoft.Json;
using Cysharp.Threading.Tasks;

namespace Gaos.ChatRoom.ChatRoom
{
    public class ExistsChatRoom
    {
        public readonly static string CLASS_NAME = typeof(ExistsChatRoom).Name;
        public static async UniTask<Gaos.Routes.Model.ChatRoomJson.ExistsChatRoomResponse> CallAsync(string chatRoomName)
        {
            const string METHOD_NAME = "CallAsync()";
            try
            {

                Gaos.Routes.Model.ChatRoomJson.ExistsChatRoomRequest request = new Gaos.Routes.Model.ChatRoomJson.ExistsChatRoomRequest();
                request.ChatRoomName = chatRoomName;
                string requestJsonStr = JsonConvert.SerializeObject(request);
                Gaos.Api.ApiCall apiCall = new Gaos.Api.ApiCall("api/chatRoom/existsChatRoom", requestJsonStr);
                await apiCall.CallAsync();
                if (apiCall.IsResponseError)
                {
                    Debug.LogError($"ERROR: error calling existsChatRoom");
                    throw new System.Exception("error calling existsChatRoom");
                }
                else
                {
                    Gaos.Routes.Model.ChatRoomJson.ExistsChatRoomResponse response = JsonConvert.DeserializeObject<Gaos.Routes.Model.ChatRoomJson.ExistsChatRoomResponse>(apiCall.ResponseJsonStr);
                    if (response.IsError == true)
                    {
                        Debug.LogError($"{CLASS_NAME}:{METHOD_NAME}: ERROR: error calling existsChatRoom: {response.ErrorMessage}");
                        throw new System.Exception($"error calling existsChatRoom: {response.ErrorMessage}");
                    }
                    return response;
                }
            }
            catch (System.Exception ex)
            {
                Debug.LogError($"{CLASS_NAME}:{METHOD_NAME}: ERROR: {ex.Message}");
                throw ex;
            }
        }

    }

    public class CreateChatRoom
    {
        public readonly static string CLASS_NAME = typeof(CreateChatRoom).Name;

        public static async UniTask<Gaos.Routes.Model.ChatRoomJson.CreateChatRoomResponse> CallAsync(string chatRoomName, bool isFriendsChatRoom)
        {
            const string METHOD_NAME = "CallAsync()";
            try
            {

                Gaos.Routes.Model.ChatRoomJson.CreateChatRoomRequest request = new Gaos.Routes.Model.ChatRoomJson.CreateChatRoomRequest();
                request.ChatRoomName = chatRoomName;
                request.IsFriedndsChatroom = isFriendsChatRoom;
                string requestJsonStr = JsonConvert.SerializeObject(request);
                Gaos.Api.ApiCall apiCall = new Gaos.Api.ApiCall("api/chatRoom/createChatRoom", requestJsonStr);
                await apiCall.CallAsync();
                if (apiCall.IsResponseError)
                {
                    Debug.LogError($"ERROR: error calling createChatRoom");
                    throw new System.Exception("error calling createChatRoom");
                }
                else
                {
                    Gaos.Routes.Model.ChatRoomJson.CreateChatRoomResponse response = JsonConvert.DeserializeObject<Gaos.Routes.Model.ChatRoomJson.CreateChatRoomResponse>(apiCall.ResponseJsonStr);
                    if (response.IsError == true)
                    {
                        Debug.LogError($"{CLASS_NAME}:{METHOD_NAME}: ERROR: error calling createChatRoom: {response.ErrorMessage}");
                        throw new System.Exception($"error calling createChatRoom: {response.ErrorMessage}");
                    }
                    return response;
                }
            }
            catch (System.Exception ex)
            {
                Debug.LogError($"{CLASS_NAME}:{METHOD_NAME}: ERROR: {ex.Message}");
                throw ex;
            }
        }
    }

    public class EnsureChatRoomExists
    {
        public readonly static string CLASS_NAME = typeof(EnsureChatRoomExists).Name;

        // Returns the chat room id if chat romm exists, otherwise returns -1
        public static async UniTask<int> CallAsync(string chatRoomName, bool isFriendsChatRoom)
        {
            const string METHOD_NAME = "CallAsync()";
            try
            {
                Gaos.Routes.Model.ChatRoomJson.ExistsChatRoomResponse existsChatRoomResponse = await ExistsChatRoom.CallAsync(chatRoomName);

                if (existsChatRoomResponse.IsExists == false)
                {
                    // Create new chat room
                    Gaos.Routes.Model.ChatRoomJson.CreateChatRoomResponse createChatRoomResponse = await CreateChatRoom.CallAsync(chatRoomName, isFriendsChatRoom);
                    return createChatRoomResponse.ChatRoomId;
                }
                else
                {
                    return existsChatRoomResponse.ChatRoomId;
                }

            }
            catch (System.Exception ex)
            {
                Debug.LogError($"{CLASS_NAME}:{METHOD_NAME}: ERROR: {ex.Message}");
                throw ex;
            }
        }


    }

    public class AddMember
    {
        public readonly static string CLASS_NAME = typeof(AddMember).Name;
        public static async UniTask<Gaos.Routes.Model.ChatRoomJson.AddMemberResponse> CallAsync(int chatRoomId, int userId)
        {
            const string METHOD_NAME = "CallAsync()";
            try
            {

                Gaos.Routes.Model.ChatRoomJson.AddMemberRequest request = new Gaos.Routes.Model.ChatRoomJson.AddMemberRequest();
                request.ChatRoomId = chatRoomId;
                request.UserId = userId;
                string requestJsonStr = JsonConvert.SerializeObject(request);
                Gaos.Api.ApiCall apiCall = new Gaos.Api.ApiCall("api/chatRoom/addMember", requestJsonStr);
                await apiCall.CallAsync();
                if (apiCall.IsResponseError)
                {
                    Debug.LogError($"ERROR: error calling addMember");
                    throw new System.Exception("error calling addMember");
                }
                else
                {
                    Gaos.Routes.Model.ChatRoomJson.AddMemberResponse response = JsonConvert.DeserializeObject<Gaos.Routes.Model.ChatRoomJson.AddMemberResponse>(apiCall.ResponseJsonStr);
                    if (response.IsError == true)
                    {
                        Debug.LogError($"{CLASS_NAME}:{METHOD_NAME}: ERROR: error calling addMember: {response.ErrorMessage}");
                        throw new System.Exception($"error calling addMember: {response.ErrorMessage}");
                    }
                    return response;
                }
            }
            catch (System.Exception ex)
            {
                Debug.LogError($"{CLASS_NAME}:{METHOD_NAME}: ERROR: {ex.Message}");
                throw ex;
            }
        }

    }

    public class ReadMessages
    {
        public readonly static string CLASS_NAME = typeof(ReadMessages).Name;
        public static async UniTask<Gaos.Routes.Model.ChatRoomJson.ReadMessagesResponse> CallAsync(int chatRoomId, int lastMessageId, int count)
        {
            const string METHOD_NAME = "CallAsync()";
            try
            {

                Gaos.Routes.Model.ChatRoomJson.ReadMessagesRequest request = new Gaos.Routes.Model.ChatRoomJson.ReadMessagesRequest();
                request.ChatRoomId = chatRoomId;
                request.LastMessageId = lastMessageId;
                request.Count = count;
                string requestJsonStr = JsonConvert.SerializeObject(request);
                Gaos.Api.ApiCall apiCall = new Gaos.Api.ApiCall("api/chatRoom/readMessages", requestJsonStr);
                await apiCall.CallAsync();
                if (apiCall.IsResponseError)
                {
                    Debug.LogError($"ERROR: error calling readMessages");
                    throw new System.Exception("error calling readMessages");
                }
                else
                {
                    Gaos.Routes.Model.ChatRoomJson.ReadMessagesResponse response = JsonConvert.DeserializeObject<Gaos.Routes.Model.ChatRoomJson.ReadMessagesResponse>(apiCall.ResponseJsonStr);
                    if (response.IsError == true)
                    {
                        Debug.LogError($"{CLASS_NAME}:{METHOD_NAME}: ERROR: error calling readMessages: {response.ErrorMessage}");
                        throw new System.Exception($"error calling readMessages: {response.ErrorMessage}");
                    }
                    return response;
                }
            }
            catch (System.Exception ex)
            {
                Debug.LogError($"{CLASS_NAME}:{METHOD_NAME}: ERROR: {ex.Message}");
                throw ex;
            }
        }

    }

    public class ReadMessagesBackwards
    {
        public readonly static string CLASS_NAME = typeof(ReadMessagesBackwards).Name;
        public static async UniTask<Gaos.Routes.Model.ChatRoomJson.ReadMessagesBackwardsResponse> CallAsync(int chatRoomId, int lastMessageId, int count)
        {
            const string METHOD_NAME = "CallAsync()";
            try
            {

                Gaos.Routes.Model.ChatRoomJson.ReadMessagesBackwardsRequest request = new Gaos.Routes.Model.ChatRoomJson.ReadMessagesBackwardsRequest();
                request.ChatRoomId = chatRoomId;
                request.LastMessageId = lastMessageId;
                request.Count = count;
                string requestJsonStr = JsonConvert.SerializeObject(request);
                Gaos.Api.ApiCall apiCall = new Gaos.Api.ApiCall("api/chatRoom/readMessagesBackwards", requestJsonStr);
                await apiCall.CallAsync();
                if (apiCall.IsResponseError)
                {
                    Debug.LogError($"ERROR: error calling readMessagesBackwards");
                    throw new System.Exception("error calling readMessagesBackwards");
                }
                else
                {
                    Gaos.Routes.Model.ChatRoomJson.ReadMessagesBackwardsResponse response = JsonConvert.DeserializeObject<Gaos.Routes.Model.ChatRoomJson.ReadMessagesBackwardsResponse>(apiCall.ResponseJsonStr);
                    if (response.IsError == true)
                    {
                        Debug.LogError($"{CLASS_NAME}:{METHOD_NAME}: ERROR: error calling readMessagesBackwards: {response.ErrorMessage}");
                        throw new System.Exception($"error calling readMessagesBackwards: {response.ErrorMessage}");
                    }
                    return response;
                }
            }
            catch (System.Exception ex)
            {
                Debug.LogError($"{CLASS_NAME}:{METHOD_NAME}: ERROR: {ex.Message}");
                throw ex;
            }
        }

    }

    public class WriteMessage
    {
        public readonly static string CLASS_NAME = typeof(WriteMessage).Name;
        public static async UniTask<Gaos.Routes.Model.ChatRoomJson.WriteMessageResponse> CallAsync(int chatRoomId, string message)
        {
            const string METHOD_NAME = "CallAsync()";
            try
            {

                Gaos.Routes.Model.ChatRoomJson.WriteMessageRequest request = new Gaos.Routes.Model.ChatRoomJson.WriteMessageRequest();
                request.ChatRoomId = chatRoomId;
                request.Message = message;
                string requestJsonStr = JsonConvert.SerializeObject(request);
                Gaos.Api.ApiCall apiCall = new Gaos.Api.ApiCall("api/chatRoom/writeMessage", requestJsonStr);
                await apiCall.CallAsync();
                if (apiCall.IsResponseError)
                {
                    Debug.LogError($"ERROR: error calling writeMessages");
                    throw new System.Exception("error calling writeMessages");
                }
                else
                {
                    Gaos.Routes.Model.ChatRoomJson.WriteMessageResponse response = JsonConvert.DeserializeObject<Gaos.Routes.Model.ChatRoomJson.WriteMessageResponse>(apiCall.ResponseJsonStr);
                    if (response.IsError == true)
                    {
                        Debug.LogError($"{CLASS_NAME}:{METHOD_NAME}: ERROR: error calling writeMessages: {response.ErrorMessage}");
                        throw new System.Exception($"error calling writeMessages: {response.ErrorMessage}");
                    }
                    return response;
                }
            }
            catch (System.Exception ex)
            {
                Debug.LogError($"{CLASS_NAME}:{METHOD_NAME}: ERROR: {ex.Message}");
                throw ex;
            }
        }

    }

    public class GetUserToFriendChatRoom
    {
        public readonly static string CLASS_NAME = typeof(GetUserToFriendChatRoom).Name;

        public static async UniTask<Gaos.Routes.Model.ChatRoomJson.GetUserToFriendChatRoomResponse> CallAsync(int friendId)
        {
            const string METHOD_NAME = "CallAsync()";
            try
            {
                // Build the request object
                Gaos.Routes.Model.ChatRoomJson.GetUserToFriendChatRoomRequest request = new Gaos.Routes.Model.ChatRoomJson.GetUserToFriendChatRoomRequest();
                request.FriendId = friendId;

                // Serialize request to JSON
                string requestJsonStr = JsonConvert.SerializeObject(request);

                // Create and call the API endpoint
                Gaos.Api.ApiCall apiCall = new Gaos.Api.ApiCall("api/chatRoom/getUserToFriendChatRoom", requestJsonStr);
                await apiCall.CallAsync();

                // Check for transport-level errors
                if (apiCall.IsResponseError)
                {
                    Debug.LogWarning($"{CLASS_NAME}:{METHOD_NAME}: ERROR: error getting chat room");
                    return null;
                }
                else
                {
                    // Deserialize the response from JSON
                    Gaos.Routes.Model.ChatRoomJson.GetUserToFriendChatRoomResponse response =
                        JsonConvert.DeserializeObject<Gaos.Routes.Model.ChatRoomJson.GetUserToFriendChatRoomResponse>(apiCall.ResponseJsonStr);

                    // Check if the API returned an error
                    if (response.IsError == true)
                    {
                        Debug.LogWarning($"{CLASS_NAME}:{METHOD_NAME}: ERROR: {response.ErrorMessage}");
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

    public class GetGroupChatRoom
    {
        public readonly static string CLASS_NAME = typeof(GetGroupChatRoom).Name;

        public static async UniTask<Gaos.Routes.Model.ChatRoomJson.GetGroupChatRoomResponse> CallAsync()
        {
            const string METHOD_NAME = "CallAsync()";
            try
            {
                // Build the request object
                Gaos.Routes.Model.ChatRoomJson.GetGroupChatRoomRequest request = new Gaos.Routes.Model.ChatRoomJson.GetGroupChatRoomRequest();

                // Serialize request to JSON
                string requestJsonStr = JsonConvert.SerializeObject(request);

                // Create and call the API endpoint
                Gaos.Api.ApiCall apiCall = new Gaos.Api.ApiCall("api/chatRoom/getGroupChatRoom", requestJsonStr);
                await apiCall.CallAsync();

                // Check for transport-level errors
                if (apiCall.IsResponseError)
                {
                    Debug.LogWarning($"{CLASS_NAME}:{METHOD_NAME}: ERROR: error getting chat room");
                    return null;
                }
                else
                {
                    // Deserialize the response from JSON
                    Gaos.Routes.Model.ChatRoomJson.GetGroupChatRoomResponse response =
                        JsonConvert.DeserializeObject<Gaos.Routes.Model.ChatRoomJson.GetGroupChatRoomResponse>(apiCall.ResponseJsonStr);

                    // Check if the API returned an error
                    if (response.IsError == true)
                    {
                        Debug.LogWarning($"{CLASS_NAME}:{METHOD_NAME}: ERROR: {response.ErrorMessage}");
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
}
