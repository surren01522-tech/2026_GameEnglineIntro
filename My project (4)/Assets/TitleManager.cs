using JetBrains.Annotations;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleManager : MonoBehaviour
{
    public GameObject helpPanel;

    public void GameStart()
    {
        SceneManager.LoadScene("PlayScenes_Door1");
    }

    public void OpenHelp()
    {
        helpPanel.SetActive(true);
    }
   
   public void CloseHelp()
    {
        helpPanel.SetActive(false);
    }
}
