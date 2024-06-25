using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Windows;
using UnityEngine.UI;
using TMPro;

public class MenuUIHandler : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI welcometext;

    public void Start()
    {
        welcometext.text = "Welcome " + PlayerDataHandle.Instance.Username + "!";
    }
    public void StartGameButton()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGameButton()
    {
        EditorApplication.ExitPlaymode();
        Application.Quit();
    }

    public void SubmitName(string s)
    {
        PlayerDataHandle.Instance.Username = s;
        welcometext.text = "Welcome " + PlayerDataHandle.Instance.Username + "!";
        PlayerDataHandle.Instance.SaveStats();
        //Debug.Log(Application.persistentDataPath);
    }
}
