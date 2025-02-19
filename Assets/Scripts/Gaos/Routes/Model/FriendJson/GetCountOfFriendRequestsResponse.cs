#pragma warning disable 8632
namespace Gaos.Routes.Model.FriendJson
{
    [System.Serializable]
    public class GetCountOfFriendRequestsResponse
    {
        public bool? IsError;
        public string? ErrorMessage;
        public int Count;
    }
}
