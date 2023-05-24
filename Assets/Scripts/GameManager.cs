using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    public static int score;
    private static GameManager instance;
    private void Awake()
    {
        instance = this;
    }
    public static GameManager GetIntance()
    {
        return instance;
    }
}
