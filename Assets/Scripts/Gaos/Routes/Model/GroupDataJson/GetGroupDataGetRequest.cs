﻿#pragma warning disable 8632
namespace Gaos.Routes.Model.GroupDataJson
{
    [System.Serializable]
    public class GetGroupDataGetRequest
    {
        public int SlotId;
        public  long Version;

        public bool IsGameDataDiff;
    }
}
