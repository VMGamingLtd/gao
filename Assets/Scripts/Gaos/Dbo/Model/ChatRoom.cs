#pragma warning disable 8632
namespace Gaos.Dbo.Model
{
    [System.Serializable]
    public class ChatRoom
    {
        public int Id;
        public string? Name;
        public int OwnerId;
        public User? Owner;
        public bool IsFriedndsChatroom;
        public bool IsGroupChatroom;

    }
}
