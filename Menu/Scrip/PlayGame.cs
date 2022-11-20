using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayGame : MonoBehaviour
{

    public GameObject Option;
    public GameObject OptionMenu;


    private void Start()
    {
        this.Option.SetActive(true);
        this.OptionMenu.SetActive(false);
    }
    public void StartGame()
    {
     
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void OptionBtn()
    {
      
        this.Option.SetActive(false);
        this.OptionMenu.SetActive(true);
    }

    public void BackBtn()
    {   
        this.OptionMenu.SetActive(false);
        this.Option.SetActive(true);
    }
    public void QuitBtn()
    {      
        Application.Quit();
    }    
}
