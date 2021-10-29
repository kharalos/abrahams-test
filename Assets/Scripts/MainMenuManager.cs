using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MainMenuManager : MonoBehaviour
{
    public void ResetLevel()
    {
        FindObjectOfType<ProgressionSaver>().ResetAndSaveLevel();
    }
    public void LoadScene(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
    public void QuitGame()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
