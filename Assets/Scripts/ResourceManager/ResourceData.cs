using System;
using UnityEngine.AddressableAssets;

namespace Assets.Scripts.ResourceManager
{
    public class ResourceData
    {
        // アセット配列からデータの索引をするためのデータ
        public sealed class ResourceAssetData
        {
            public uint ResourceID;
            public string ResourceName;

            public ResourceAssetData(uint ID, string name)
            {
                ResourceID = ID;
                ResourceName = name;
            } 
        }

        public ResourceAssetData[] Resources = new ResourceAssetData[] 
        {
            new ResourceAssetData((uint)0, "Player"),

            // Boxプレハブ
            new ResourceAssetData((uint)1, "BlueBox"),
            new ResourceAssetData((uint)2, "RedBox"),
            new ResourceAssetData((uint)3, "GreenBox"),
        };
    }
}
