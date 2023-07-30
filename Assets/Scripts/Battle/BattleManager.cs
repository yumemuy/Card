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

    void Start()
    {
        InitParticipant();
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
}
