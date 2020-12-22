using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deputy : GameInfo
{
    GameInfo Session = new GameInfo();

    public override void CompleteLvl()
    {
        Session.CompleteLvl();
        Debug.Log("Текущий уровень: " + Session.CurrentLvl);
    }
}
