#pragma warning disable 8632
namespace Gaos.Routes.Model.ChatRoomJson
{
    [System.Serializable]
    public class GetUnreadMessagesCountResponse
    {
        public bool? IsError;
        public string? ErrorMessage;

        public int userId;
        public int count;
    }
}
