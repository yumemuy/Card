using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;

public class Deck : MonoBehaviour
{
    private List<int> _deck;

    private void Start()
    {
        // 仮デッキデータ
        _deck = new List<int>();
        _deck.Clear();
        for (int i = 0; i < 30; ++i)
        {
            _deck.Add(i + 1);
        }
    }

    public void Shuffle()
    {
        _deck = _deck.OrderBy(_ => Guid.NewGuid()).ToList();
    }

    public int Draw()
    {
        var card = _deck.First();
        _deck.RemoveAt(0);
        return card;
    }
}
