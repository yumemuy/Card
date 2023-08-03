using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardData : MonoBehaviour
{
    protected const string ASSET_PATH = "Card";

    protected CardKind _cardKind = CardKind.NONE;

    protected CardSO _cardParam;

    public CardKind cardKind => _cardKind;

    public virtual string Name => _cardParam.name;

    public virtual int Id => _cardParam.cardID;

    public virtual int Atk => _cardParam.atk;

    public virtual int Def => _cardParam.def;

    public void SetParam(int id)
    {
        _cardParam = Resources.Load<CardSO>(ASSET_PATH + id.ToString());
        _cardKind = _cardParam.kind;
    }
}
