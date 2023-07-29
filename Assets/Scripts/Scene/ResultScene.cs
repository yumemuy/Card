using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ResultScene : MonoBehaviour
{
    [SerializeField] private Button _retryButton;
    [SerializeField] private Button _titleBackButton;

    // Start is called before the first frame update
    void Start()
    {
        _retryButton.onClick.AddListener(OnClickRetryButton);
        _titleBackButton.onClick.AddListener(OnClickTitleBackButton);
    }

    private void OnDisable()
    {
        _retryButton.onClick.RemoveAllListeners();
        _titleBackButton.onClick.RemoveAllListeners();
    }

    void OnClickRetryButton()
    {
        SceneManager.LoadScene("Battle");
    }

    void OnClickTitleBackButton()
    {
        SceneManager.LoadScene("Title");
    }
}
