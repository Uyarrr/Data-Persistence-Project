using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDataHandle : MonoBehaviour
{
    //Static Class for save the current player data;
    //Singleton pattern

    public static PlayerDataHandle Instance;
    private LoadGameStats loadgamestats;
    public string Username;
    public int Score;

    private void Awake()
    {
        //we dont actually need this if statement because when we are in the Main Scene we cant return to the Start Menu Scene where the Player Data Handle Object already exists.
        if (Instance != null)
        {
            Destroy(gameObject);
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
[System.Serializable]
public class SaveData
{
    public int Score;
}
