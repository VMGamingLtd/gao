#pragma warning disable 8632
namespace Gaos.Dbo.Model
{
    [System.Serializable]
    public class ChatRoomMember
    {
        public int Id;
        public int ChatRoomId;
        public ChatRoom? ChatRoom;
        public int UserId;
        public User? User;
    }
}
