#pragma warning disable 8632
namespace Gaos.Routes.Model.ChatRoomJson
{
    [System.Serializable]
    public class GetGroupChatRoomResponse
    {
        public bool? IsError;
        public string? ErrorMessage;

        public int? ChatRoomId;
        public string? ChatRoomName;
    }
}
