using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeScene : MonoBehaviour
{
    public static int number_of_pieces;
    public GameObject imagehelper ;
    public GameObject Panel ;
   
    public GameObject menupanel;
    int x = 0;
    public void StartPlay()
    {
        SceneManager.LoadSceneAsync(1);
    }
    public void Quitgame()
    {
        Application.Quit();
    }
    public void BackToMainPage()
    {
        SceneManager.LoadSceneAsync(0);
    }
    public void BackToChosseLevel()
    {
        SceneManager.LoadSceneAsync(1);
    }
    public void BackToChosseimage()
    {
        SceneManager.LoadSceneAsync(2);
    }
    public void StartLevel1()
    {
        number_of_pieces = 4;
        SceneManager.LoadSceneAsync(2);
        // menupanel.SetActive(false);


    }
    public void StartLevel2()
    {
        number_of_pieces = 9;
        SceneManager.LoadSceneAsync(2);
        // menupanel.SetActive(false)

    }
    public void StartLevel3()
    {
        number_of_pieces = 16;
        SceneManager.LoadSceneAsync(2);
        // menupanel.SetActive(false);

    }
    public void HelperImage()
    {
        if (x == 0)
        {
            imagehelper.SetActive(true);
            Panel.SetActive(false);
            x = 1;
        }else
        {
            imagehelper.SetActive(false);
            Panel.SetActive(true);
            x = 0;
        }
    }
    public void OpenMenuPanel()
    {
        menupanel.SetActive(true);
    }
    public void Continue()
    {
        menupanel.SetActive(false);
    }
}

    
