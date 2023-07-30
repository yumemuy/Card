using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleManager : MonoBehaviour
{
    [SerializeField]
    private GameObject _playerFieldPrefab;
    [SerializeField]
    private GameObject _enemyFieldPrefab;
    [SerializeField]
    private Transform _playerTranform;
    [SerializeField]
    private Transform _enemyTranform;
    private ParticipantBase _player;
    private ParticipantBase _enemy;
    private bool _isPlayerTurn;
    private bool _isTurnEnd;

    void Start()
    {
        InitParticipant();
        _isPlayerTurn = true;
        _isTurnEnd = true;
    }

    private void InitParticipant()
    {
        var player_field = Instantiate(_playerFieldPrefab);
        player_field.transform.SetParent(_playerTranform, false);
        _player = new Enemy();
        _player.SetFieldManager(player_field.GetComponent<FieldManager>());

        var enemy_field = Instantiate(_enemyFieldPrefab);
        enemy_field.transform.SetParent(_enemyTranform, false);
        _enemy = new Enemy();
        _enemy.SetFieldManager(enemy_field.GetComponent<FieldManager>());
    }

    private void Update()
    {
        if (_isPlayerTurn)
        {
            if (_isTurnEnd)
                StartCoroutine(TurnFunc(_player));
        }
        else
        {
            if (_isTurnEnd)
                StartCoroutine(TurnFunc(_enemy));
        }
    }

    public IEnumerator TurnFunc(ParticipantBase participant)
    {
        _isTurnEnd = false;

        // ドロー
        yield return participant.DrawPhase();

        // スタンバイ
        yield return participant.StandByPhase();

        // メイン
        yield return participant.MainPhase();

        // バトル
        yield return participant.BattlePhase();

        // メイン２
        yield return participant.MainPhase2();

        _isTurnEnd = true;
        _isPlayerTurn = !_isPlayerTurn;
    }
}
