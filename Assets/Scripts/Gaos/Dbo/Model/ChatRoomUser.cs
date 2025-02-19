#pragma warning disable 8632
namespace Gaos.Dbo.Model
{
    [System.Serializable]
    public class ChatRoomUser
    {
        public int Id;
        public int ChatRoomId;
        public ChatRoom? ChatRoom;
        public int UserId;
        public User? User;
        public int LastReadMessageId;
    }
}
