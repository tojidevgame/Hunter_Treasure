using System.Collections.Generic;
using UnityEngine;


public struct DataStartGamePlay
{
    private int levelId;
    private Explorer explorer;
    private List<KeyValuePair<ItemType, int>> itemsType;

    public DataStartGamePlay(int levelId, Explorer explorer, List<KeyValuePair<ItemType, int>> itemsType)
    {
        this.levelId = levelId;
        this.explorer = explorer;
        this.itemsType = itemsType;
    }

    // public getters and setters for private properties
    public int LevelId { get => levelId; set => levelId = value; }
    public Explorer Explorer { get => explorer; set => explorer = value; }
    public List<KeyValuePair<ItemType, int>> ItemsType { get => itemsType; set => itemsType = value; }
}

public struct DataEndGame
{
    private bool isWin;

    // info explorer
    private int levelId;
    private Explorer explorer;
    private List<KeyValuePair<ItemType, int>> itemsType;

    // reward
    private List<KeyValuePair<CurrencyType, int>> currenciesType;

    public DataEndGame(bool isWin, int levelId, Explorer explorer, List<KeyValuePair<ItemType, int>> itemsType, List<KeyValuePair<CurrencyType, int>> currenciesType)
    {
        this.isWin = isWin;
        this.levelId = levelId;
        this.explorer = explorer;
        this.itemsType = itemsType;
        this.currenciesType = currenciesType;
    }

    // public getters and setters for private properties    
    public bool IsWin { get => isWin; set => isWin = value; }
    public int LevelId { get => levelId; set => levelId = value; }
    public Explorer Explorer { get => explorer; set => explorer = value; }
    public List<KeyValuePair<ItemType, int>> ItemsType { get => itemsType; set => itemsType = value; }
    public List<KeyValuePair<CurrencyType, int>> CurrenciesType { get => currenciesType; set => currenciesType = value; }
}

[CreateAssetMenu(fileName = "RuntimeGlobalData", menuName = "HunterTreasure/Global/RuntimeGlobalData")]
public class RuntimeGlobalData : ScriptableObject
{
    private DataStartGamePlay dataStartGamePlay;
    private DataEndGame dataEndGame;

    // public getters and setters for private properties
    public DataStartGamePlay DataStartGamePlay { get => dataStartGamePlay; set => dataStartGamePlay = value; }
    public DataEndGame DataEndGame { get => dataEndGame; set => dataEndGame = value; }
}
