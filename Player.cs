using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    GameInfo Session = new GameInfo();
    Deputy dep = new Deputy();
    CheckLvl check = new CheckLvl();
    

    private void Start()
    {
        Session.CompleteLvl();
        dep.CompleteLvl();
        check.CompleteLvl();
        //Debug.Log(Session.Score);
    }
}
