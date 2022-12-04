using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AddressableAssets;
using Asset.Scripts.ResourceManager;

public class GameManager : Singleton<GameManager>
{
    private ResourceManager _resouceManager;
    void Start()
    {
        var playerResource = _resouceManager.GetResourceName(0);
        Addressables.InstantiateAsync(playerResource);
    }

    void Update()
    {
        
    }

    protected override void Init()
    {
        base.Init();
        _resouceManager = ResourceManager.Instance;
    }
}
