using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DeckSelectScene : MonoBehaviour
{
    [SerializeField] private Button _battleStartButton;

    void Start()
    {
        _battleStartButton.onClick.AddListener(OnClickBattleStartButton);
    }

    private void OnDisable()
    {
        _battleStartButton.onClick.RemoveAllListeners();
    }

    void OnClickBattleStartButton()
    {
        SceneManager.LoadScene("Battle");
    }
}
