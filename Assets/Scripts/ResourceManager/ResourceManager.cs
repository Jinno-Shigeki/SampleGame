using System;
using UnityEngine.AddressableAssets;
using Assets.Scripts.ResourceManager;

namespace Asset.Scripts.ResourceManager
{
    public class ResourceManager
    {
        private static ResourceManager _instance = null;
        public static ResourceManager Instance { 
            get
            {
                if (_instance == null)
                {
                    _instance = new ResourceManager();
                    _instance.Init();
                }
                return _instance;
            }
        }
        public bool IsDestoroy = false;
        private ResourceData _resourceData = null;

        void Init()
        {
            _instance._resourceData = new ResourceData();
        }

        void Destoroy()
        {
            _instance = null;
        }

        public string GetResourceName(uint id)
        {
            return _resourceData.Resources[id].ResourceName;
        }
    }
}
