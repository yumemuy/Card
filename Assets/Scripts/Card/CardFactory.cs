using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardFactory : MonoBehaviour
{
    private static CardFactory _instance;

    public static CardFactory Instance => _instance;

    [SerializeField]
    private GameObject _cardPrefab;

    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
        }
        else if (_instance != this)
        {
            Destroy(this);
        }
    }

    public GameObject CreateCard(int id)
    {
        var card = Instantiate(_cardPrefab, Vector3.zero, Quaternion.identity);
        card.GetComponent<Card>().Init(id);
        return card;
    }
}
