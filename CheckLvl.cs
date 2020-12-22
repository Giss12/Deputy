using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckLvl : GameInfo
{
    GameInfo Session = new GameInfo();

    public override void CompleteLvl()
    {
        Session.CompleteLvl();
        Session.Score += 100;
        Debug.Log("Очков : " + Session.Score);
    }
}
