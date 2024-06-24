using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class LoadGameStats : MonoBehaviour
{
    //Fields for display the player info
    public Text BestPlayerName;

    //Static variables for holding the best player data
    private static int BestScore;
    private static string BestPlayer;
    private void Awake()
    {
        LoadGameRank();
    }

    public void LoadGameRank()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);


            PlayerDataHandle.Instance.Score = data.Score;
        }
    }

    private void SetBestPlayer()
    {
        if (BestPlayer == null && BestScore == 0)
        {
            BestPlayerName.text = "";
        }
        else
        {
            BestPlayerName.text = $"Best Score - {BestPlayer}: {BestScore}";
        }
    }