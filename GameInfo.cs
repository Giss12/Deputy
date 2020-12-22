using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInfo 
{
    public int CurrentLvl;
    public int Score;

    public void ChangeScore(int value)
    {
        Score += value;
    }

    public virtual void CompleteLvl()
    {
        CurrentLvl++;
    }
}
