using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartPlaying : MonoBehaviour
{
    public string leveltoload;
    public int loaddelay;
    public Button StartButton;
    // Start is called before the first frame update
    void Start()
    {
        StartButton.onClick.AddListener(StartTheGame);
    }

    // Update is called once per frame
    void StartTheGame()
    {
        //Debug.Log("oui");
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
