using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticipantBase : MonoBehaviour
{
    protected FieldManager _fieldManager;

    public virtual IEnumerator DrawPhase()
    {
        yield return null;
    }

    public virtual IEnumerator StandByPhase()
    {
        yield return null;
    }

    public virtual IEnumerator MainPhase()
    {
        yield return null;
    }


    public virtual IEnumerator BattlePhase()
    {
        yield return null;
    }


    public virtual IEnumerator MainPhase2()
    {
        yield return null;
    }

    public void SetFieldManager(FieldManager manager)
    {
        _fieldManager = manager;
    }
}