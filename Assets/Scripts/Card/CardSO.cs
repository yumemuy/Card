using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CardSO", menuName ="Create Card")]
public class CardSO : ScriptableObject
{
    // ƒpƒ‰ƒ[ƒ^
    public int cardID;
    public string name;
    public CardKind kind;
    public int atk;
    public int def;
}
