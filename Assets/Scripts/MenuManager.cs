using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuManager : MonoBehaviour
{
    private TextMeshProUGUI userName;
    private DataBetweenScenes userData;

    private void Start()
    {
        userName = GameObject.Find("UserNameText").GetComponent<TextMeshProUGUI>();
    }
    public void StartGame()
    {
        Debug.Log("User Name is " + userName.text);
        SceneManager.LoadScene(1);
        DataBetweenScenes.Instance.userName = userName.text;
        Debug.Log("User Name is " + userName.text);
    }

    public void ExitGame()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
