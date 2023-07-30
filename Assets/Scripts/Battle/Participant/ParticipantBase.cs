using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticipantBase : MonoBehaviour
{
    protected FieldManager _fieldManager;

    public virtual IEnumerable DrawPhase()
    {
        yield return null;
    }

    public virtual IEnumerable StandByPhase()
    {
        yield return null;
    }

    public virtual IEnumerable MainPhase()
    {
        yield return null;
    }


    public virtual IEnumerable BattlePhase()
    {
        yield return null;
    }


    public virtual IEnumerable MainPhase2()
    {
        yield return null;
    }

    public void SetFieldManager(FieldManager manager)
    {
        _fieldManager = manager;
    }
}