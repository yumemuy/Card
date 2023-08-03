using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : ParticipantBase
{
    public override IEnumerator DrawPhase(bool is_first_turn)
    {
        Debug.Log("ドローフェイズ　－開始－");

        yield return new WaitForSeconds(3.0f);
        PhaseActions.Draw(_fieldManager.CardDeck, _fieldManager.HandField.transform);

        Debug.Log("ドローフェイズ　－終了－");
    }

    public override IEnumerator StandByPhase()
    {
        Debug.Log("スタンバイフェイズ　－開始－");

        yield return new WaitForSeconds(3.0f);

        Debug.Log("スタンバイフェイズ　－終了－");
    }

    public override IEnumerator MainPhase()
    {
        Debug.Log("メインフェイズ　－開始－");

        yield return new WaitForSeconds(3.0f);

        Debug.Log("メインフェイズ　－終了－");
    }

    public override IEnumerator BattlePhase()
    {
        Debug.Log("バトルフェイズ　－開始－");

        yield return new WaitForSeconds(3.0f);

        Debug.Log("バトルフェイズ　－終了－");
    }

    public override IEnumerator MainPhase2()
    {
        Debug.Log("メインフェイズ２　－開始－");

        yield return new WaitForSeconds(3.0f);

        Debug.Log("メインフェイズ２　－終了－");
    }
}
