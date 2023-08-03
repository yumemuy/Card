using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FieldManager : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI _lifeView;
    [SerializeField]
    private GameObject _handField;
    [SerializeField]
    private GameObject _monsterZone;
    [SerializeField]
    private GameObject _magicZone;
    [SerializeField]
    private Deck _cardDeck;

    public GameObject HandField => _handField;

    public GameObject MonsterField => _monsterZone;

    public GameObject MagicField => _magicZone;

    public Deck CardDeck => _cardDeck;

    public void SetLife(int life)
    {
        _lifeView.text = life.ToString();
    }
}
