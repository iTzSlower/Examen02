using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreAdd : Score
{
    
    public void AddScore(int a)
    {
        scores = a;
        Add();
    }
}
