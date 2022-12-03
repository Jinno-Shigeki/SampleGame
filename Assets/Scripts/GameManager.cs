using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AddressableAssets;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    /// <summary>
    /// Score
    /// </summary>
    public int Score { get; private set; }

    void Start()
    {
        var blueBox = Addressables.InstantiateAsync("BlueBox");
        var player = Addressables.InstantiateAsync("Player");
        Debug.Log("aaaa");
    }

    void Update()
    {
        
    }
}
