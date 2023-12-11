
using Cysharp.Threading.Tasks;
using UnityEngine;

public abstract class BaseLoadGameController : ScriptableObject
{
    protected virtual async UniTask OnBeforeLoad()
    {
    }

    protected virtual async UniTask OnLoad()
    {
    }

    protected virtual async UniTask OnAfterLoad()
    {
    }

    public virtual async UniTask LoadGame()
    {
        await OnBeforeLoad();
        await OnLoad();
        await OnAfterLoad();    
    }
}
