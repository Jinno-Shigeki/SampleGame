using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : Singleton<T>
{
    protected virtual bool DestroyTargetGameObject => false;

    public static T Instance { get; private set; } = null;
    /// <summary>
    /// Singletonが有効か
    /// </summary>
    public static bool InValid() => Instance != null;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this as T;
            Instance.Init();
            return;
        }
        if (DestroyTargetGameObject)
        {
            Destroy(gameObject);
        }
    }
    /// <summary>
    /// 派生クラス用のAwake
    /// </summary>
    protected virtual void Init()
    {

    }
}
