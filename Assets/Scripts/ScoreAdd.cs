using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreAdd : Score
{
    private delegate int sco(int a);
    
    public void AddScore(int a)
    {
        scores = a;
        Add();
        Notify();
    }
}
