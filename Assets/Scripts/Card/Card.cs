using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Card : MonoBehaviour
{
    // view
    [SerializeField]
    private TextMeshProUGUI _nameText;
    [SerializeField]
    private TextMeshProUGUI _atkText;
    [SerializeField]
    private TextMeshProUGUI _defText;

    // data
    private bool _isUpdate;
    private int _atk;
    private int _def;

    public int atk => _atk;

    public int def => _def;

    private CardData _cardData;

    public void Init(int id)
    {
        _cardData = new CardData();
        _cardData.SetParam(id);

        switch (_cardData.cardKind)
        {
            case CardKind.MONSTER:
                {
                    _atk = _cardData.Atk;
                    _def = _cardData.Def;
                    _isUpdate = true;
                }
                break;

            case CardKind.MAGIC:
                break;

            default:
                break;
        }
    }

    void Update()
    {
        if (_isUpdate)
        {
            UpdateView();
        }
    }

    void UpdateView()
    {
        _nameText.text = _cardData.Name;
        _atkText.text = _atk.ToString();
        _defText.text = _def.ToString();
    }
}
