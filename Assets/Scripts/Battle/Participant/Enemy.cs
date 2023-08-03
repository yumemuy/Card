using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : ParticipantBase
{
    public override IEnumerator DrawPhase(bool is_first_turn)
    {
        Debug.Log("�h���[�t�F�C�Y�@�|�J�n�|");

        yield return new WaitForSeconds(3.0f);
        PhaseActions.Draw(_fieldManager.CardDeck, _fieldManager.HandField.transform);

        Debug.Log("�h���[�t�F�C�Y�@�|�I���|");
    }

    public override IEnumerator StandByPhase()
    {
        Debug.Log("�X�^���o�C�t�F�C�Y�@�|�J�n�|");

        yield return new WaitForSeconds(3.0f);

        Debug.Log("�X�^���o�C�t�F�C�Y�@�|�I���|");
    }

    public override IEnumerator MainPhase()
    {
        Debug.Log("���C���t�F�C�Y�@�|�J�n�|");

        yield return new WaitForSeconds(3.0f);

        Debug.Log("���C���t�F�C�Y�@�|�I���|");
    }

    public override IEnumerator BattlePhase()
    {
        Debug.Log("�o�g���t�F�C�Y�@�|�J�n�|");

        yield return new WaitForSeconds(3.0f);

        Debug.Log("�o�g���t�F�C�Y�@�|�I���|");
    }

    public override IEnumerator MainPhase2()
    {
        Debug.Log("���C���t�F�C�Y�Q�@�|�J�n�|");

        yield return new WaitForSeconds(3.0f);

        Debug.Log("���C���t�F�C�Y�Q�@�|�I���|");
    }
}
