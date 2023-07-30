using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterCard : CardBase
{
    private const string ASSET_PATH = "Assets/Resouces/Card";
    private CardSO _cardParam;

    public string Name => _cardParam.name;

    public int Id => _cardParam.cardID;

    public int Atk => _cardParam.atk;

    public int Def => _cardParam.def;

    public override void SetParam(int id)
    {
        _cardParam = Resources.Load<CardSO>(ASSET_PATH + id.ToString());
    }
}
