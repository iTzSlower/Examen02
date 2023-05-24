using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public abstract class Score : MonoBehaviour, IObserver
{
    [SerializeField]
    protected TMP_Text canTXT;

    protected int scores;
    protected void Start()
    {
        canTXT.text = "SCORE: " + 0;
    }
    protected void Update()
    {
        canTXT.text = "SCORE: " + GameManager.score;
    }
    protected void Add()
    {
        GameManager.score += scores;
    }
    public void Notify()
    {
        Debug.Log("Se sumo " + scores);
    }
}
