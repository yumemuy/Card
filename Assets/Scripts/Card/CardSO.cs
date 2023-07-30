using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CardSO", menuName ="Create Card")]
public class CardSO : ScriptableObject
{
    // �p�����[�^
    public int cardID;
    public string name;
    public int atk;
    public int def;
}
