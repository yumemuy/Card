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
    private GameObject _monsterField;
    [SerializeField]
    private GameObject _magicField;
    [SerializeField]
    private Deck _cardDeck;

    public GameObject HandField => _handField;

    public GameObject MonsterField => _monsterField;

    public GameObject MagicField => _magicField;

    public Deck CardDeck => _cardDeck;

    public void SetLife(int life)
    {
        _lifeView.text = life.ToString();
    }
}
