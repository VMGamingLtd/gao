﻿#pragma warning disable 8632
namespace Gaos.Routes.Model.GroupDataJson
{
    [System.Serializable]
    public class SaveGroupDataRequest
    {
        public int SlotId;
        public string? GroupDataJson;
        public long Version;
        public bool IsJsonDiff;
    }
}
