using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleScene : MonoBehaviour
{
    [SerializeField] private Button _vsCpuButton;

    void Start()
    {
        _vsCpuButton.onClick.AddListener(OnClickVsCpuButton);
    }

    private void OnDisable()
    {
        _vsCpuButton.onClick.RemoveAllListeners();
    }

    void OnClickVsCpuButton()
    {
        SceneManager.LoadScene("DeckSelect");
    }
}
