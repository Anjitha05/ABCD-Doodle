using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenChoiceMenu : MonoBehaviour
{
    [SerializeField] private GameObject choicePanel;
    public void OnButtonPlayClick()
    {
        choicePanel.SetActive(true);
    }
    public void OnButtonQuitClick()
    {
        Application.Quit();
        Debug.Log("Application will Close now");
    }
    public void OnCloseButtonClick()
    {
        choicePanel.SetActive(false);
    }
    public void OnABCDButtonClick()
    {
        Debug.Log("change the ABCD scene");
        SceneManager.LoadScene(1);
    }
    public void OnabcdButtonClick()
    {
        Debug.Log("change the abcd scene");
    }
    public void OnBackButtonClick()
    {
         SceneManager.LoadScene(0);
    }
}
