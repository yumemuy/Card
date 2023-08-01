using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhaseActions
{
    public static void Draw(Deck deck, Transform hand)
    {
        var id = deck.Draw();
        var card = CardFactory.Instance.CreateCard(id);
        card.gameObject.transform.SetParent(hand);
    }
}
