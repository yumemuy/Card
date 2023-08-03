using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhaseActions
{
    public static void InitHand(FieldManager field_manager)
    {
        for (int i = 0; i < 5; ++i)
        {
            Draw(field_manager.CardDeck, field_manager.HandField.transform);
        }
    }

    public static void Draw(Deck deck, Transform hand)
    {
        var id = deck.Draw();
        var card = CardFactory.Instance.CreateCard(id);
        card.gameObject.transform.SetParent(hand);
    }

    public static bool CardSet(GameObject card, GameObject select_field)
    {
        var field_cell = select_field.GetComponent<FieldCell>();

        if (field_cell.card != null)
        {
            return false;
        }

        field_cell.card = card.GetComponent<Card>();
        card.transform.SetParent(select_field.transform);

        return true;
    }
}
