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
    private bool _isFirstTurn;
    private bool _isGameEnd;
    private bool _isGameStart;

    private void Start()
    {
        InitParticipant();
        _isPlayerTurn = true;
        _isTurnEnd = true;
        _isFirstTurn = true;
        _isGameEnd = false;
        _isGameStart = false;
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

    private void PreparationGame()
    {
        // �f�b�L�V���b�t��
        _player.fieldManager.CardDeck.Shuffle();
        _enemy.fieldManager.CardDeck.Shuffle();

        // ��D�p��
        PhaseActions.InitHand(_player.fieldManager);
        PhaseActions.InitHand(_enemy.fieldManager);
    }

    private void Update()
    {
        if (!_isGameStart)
        {
            PreparationGame();
            _isGameStart = true;
        }

        StartCoroutine(GameMain());
    }

    private IEnumerator TurnFunc(ParticipantBase participant)
    {
        _isTurnEnd = false;

        // �h���[
        yield return participant.DrawPhase(_isFirstTurn);

        // �X�^���o�C
        yield return participant.StandByPhase();

        // ���C��
        yield return participant.MainPhase();

        // �o�g��
        yield return participant.BattlePhase();

        // ���C���Q
        yield return participant.MainPhase2();

        _isTurnEnd = true;
        _isFirstTurn = false;
        _isPlayerTurn = !_isPlayerTurn;
    }

    private IEnumerator GameMain()
    {
        if (_isTurnEnd)
        {
            yield return TurnFunc(_isPlayerTurn ? _player : _enemy);
        }
    }
}
