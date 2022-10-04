using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;
using TMPro;
using System;

public class PLAYERS : MonoBehaviour
{

    public TMP_InputField firstPlayer;
    public TMP_InputField secondPLayer;
    public TMP_InputField playerHp;
    // Start is called before the first frame update
    public GameObject videoplayerGO;

    public VideoClip vc1;

void Start()
{
    videoplayerGO.gameObject.GetComponent<VideoPlayer>().clip = vc1;
    videoplayerGO.gameObject.GetComponent<VideoPlayer>().Play();
}
public void setVariable()
{
    dataHandler.vPasser.pName1 = firstPlayer.text;
    dataHandler.vPasser.pName2 = secondPLayer.text;
    dataHandler.vPasser.pHealth = System.Convert.ToInt32(playerHp.text);
    SceneManager.LoadScene(2);
}

}




