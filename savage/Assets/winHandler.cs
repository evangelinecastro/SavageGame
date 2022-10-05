using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class winHandler : MonoBehaviour
{
    
    public int winnerNum;
    public VideoPlayer vidWinner;
    public VideoClip player1Win;
    public VideoClip player2Win;

    void Awake()
    {
        winnerNum = dataHandler.vPasser.winner;
    }
    void Start()
    {
        winnerTitle();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void winnerTitle()
    {
        if (winnerNum == 1)
        {
            
            vidWinner.gameObject.GetComponent<VideoPlayer>().clip = player1Win;
            vidWinner.gameObject.GetComponent<VideoPlayer>().Play();
        }

        else
        {
           
            vidWinner.gameObject.GetComponent<VideoPlayer>().clip = player2Win;
            vidWinner.gameObject.GetComponent<VideoPlayer>().Play();
        }
    }

    public void butRestart()
    {
        SceneManager.LoadScene(1);
    }
    public void QuitButton ()
    {
        Debug.Log("QUIT!");
        Application.Quit();

    }
}