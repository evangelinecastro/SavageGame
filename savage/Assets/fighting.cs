using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class fighting : MonoBehaviour
{
    public TextMeshProUGUI pOneName;
    public TextMeshProUGUI pTwoName;
    public TextMeshProUGUI pOneHPUI;
    public TextMeshProUGUI pTwoHPUI;


    public int pOneHP;
    public int pTwoHP;

    public Button sOne;
    public Button sTwo;

    public VideoPlayer defaultSr;
    public VideoPlayer attackSr;
    public GameObject rawAttack;
    public VideoClip defaultVid;

    public VideoClip p1LowKick;
    public VideoClip p1HighKick;
    public VideoClip p1LowPunch;
    public VideoClip p1HighPunch;
    public VideoClip p1Special;

    public VideoClip p2LowKick;
    public VideoClip p2HighKick;
    public VideoClip p2LowPunch;
    public VideoClip p2HighPunch;
    public VideoClip p2Special;

    

    public VideoClip mp1LowKick;
    public VideoClip mp1HighKick;
    public VideoClip mp1LowPunch;
    public VideoClip mp1HighPunch;
    public VideoClip mp1Special;

    public VideoClip mp2LowKick;
    public VideoClip mp2HighKick;
    public VideoClip mp2LowPunch;
    public VideoClip mp2HighPunch;
    public VideoClip mp2Special;

    void Awake()
    {
        pOneName.text = dataHandler.vPasser.pName1;
        pTwoName.text = dataHandler.vPasser.pName2;
        pOneHP = dataHandler.vPasser.pHealth;
        pTwoHP = dataHandler.vPasser.pHealth;
    }
    // Start is called before the first frame update
    void Start()
    {
        defaultSr.gameObject.GetComponent<VideoPlayer>().clip = defaultVid;
        defaultSr.gameObject.GetComponent<VideoPlayer>().Play();
    }

    // Update is called once per frame
    void Update()
    {
        pOneHPUI.text = pOneHP + "";
        pTwoHPUI.text = pTwoHP + "";
        StartCoroutine(healthChecker());
    }

    public void dealDamage(int playerNum, int playerHP, int damage)
    {
        if (playerNum == 1)
            {
                playerHP -= damage;
                pTwoHP = playerHP;
                rawAttack.SetActive(false);
            }

        else
            {
                playerHP -= damage;
                pOneHP = playerHP;
                rawAttack.SetActive(false);
            }
    }

    public void playerOneLowPunch()
    {
        attackSr.gameObject.GetComponent<VideoPlayer>().clip = p1LowPunch;
        attackSr.gameObject.GetComponent<VideoPlayer>().Play();
        rawAttack.SetActive(true);
        StartCoroutine(delayProcess(1,75,1));
        Debug.Log("Success");
    }

    public void playerOneHighPunch()
    {
        attackSr.gameObject.GetComponent<VideoPlayer>().clip = p1HighPunch;
        attackSr.gameObject.GetComponent<VideoPlayer>().Play();
        StartCoroutine(delayProcess(1,55,2));
        Debug.Log("Success");
    }

    public void playerOneLowKick()
    {
        attackSr.gameObject.GetComponent<VideoPlayer>().clip = p1LowKick;
        attackSr.gameObject.GetComponent<VideoPlayer>().Play();
        StartCoroutine(delayProcess(1,65,3));
        Debug.Log("Success");
    }

    public void playerOneHighKick()
    {
        attackSr.gameObject.GetComponent<VideoPlayer>().clip = p1HighKick;
        attackSr.gameObject.GetComponent<VideoPlayer>().Play();
        StartCoroutine(delayProcess(1,45,4));
        Debug.Log("Success");
    }

    public void playerOneSpecial()
    {
        attackSr.gameObject.GetComponent<VideoPlayer>().clip = p1Special;
        attackSr.gameObject.GetComponent<VideoPlayer>().Play();
        StartCoroutine(delayProcess(1,90,5));
        sOne.interactable = false;
        Debug.Log("Success");
    }
    
    
    public void playerTwoLowPunch()
    {
        attackSr.gameObject.GetComponent<VideoPlayer>().clip = p2LowPunch;
        attackSr.gameObject.GetComponent<VideoPlayer>().Play();
        StartCoroutine(delayProcess(2,75,1));
        Debug.Log("Success");
    }

    public void playerTwoHighPunch()
    {
        attackSr.gameObject.GetComponent<VideoPlayer>().clip = p2HighPunch;
        attackSr.gameObject.GetComponent<VideoPlayer>().Play();
        StartCoroutine(delayProcess(2,55,2));
        Debug.Log("Success");
    }

    public void playerTwoLowKick()
    {
        attackSr.gameObject.GetComponent<VideoPlayer>().clip = p2LowKick;
        attackSr.gameObject.GetComponent<VideoPlayer>().Play();
        StartCoroutine(delayProcess(2,65,3));
        Debug.Log("Success");
    }

    public void playerTwoHighKick()
    {
        attackSr.gameObject.GetComponent<VideoPlayer>().clip = p2HighKick;
        attackSr.gameObject.GetComponent<VideoPlayer>().Play();
        StartCoroutine(delayProcess(2,45,4));
        Debug.Log("Success");
    }

    public void playerTwoSpecial()
    {
        attackSr.gameObject.GetComponent<VideoPlayer>().clip = p2Special;
        attackSr.gameObject.GetComponent<VideoPlayer>().Play();
        StartCoroutine(delayProcess(2,90,5));
        sTwo.interactable = false;
        Debug.Log("Success");
    }

    public IEnumerator delayProcess(int playerNumber, int accuracy,int attackNumber)
    {   
        int x = Random.Range(0,101);
   
        if (playerNumber == 1)
        {   
            if (x <= accuracy)
            {
                    switch (attackNumber)
                    {
                    case 1:
                    attackSr.gameObject.GetComponent<VideoPlayer>().clip = p1LowPunch;
                    attackSr.gameObject.GetComponent<VideoPlayer>().Play();
                    rawAttack.SetActive(true);
                    yield return new WaitForSeconds(2);
                    dealDamage(1,pTwoHP,3);
                    Debug.Log("Success");
                    break;

                    case 2:
                    attackSr.gameObject.GetComponent<VideoPlayer>().clip = p1HighPunch;
                    attackSr.gameObject.GetComponent<VideoPlayer>().Play();
                    rawAttack.SetActive(true);
                    yield return new WaitForSeconds(3);
                    dealDamage(1,pTwoHP,8);
                    break;

                    case 3:
                    attackSr.gameObject.GetComponent<VideoPlayer>().clip = p1LowKick;
                    attackSr.gameObject.GetComponent<VideoPlayer>().Play();
                    rawAttack.SetActive(true);
                    yield return new WaitForSeconds(2);
                    dealDamage(1,pTwoHP,6);
                    break;

                    case 4:
                    attackSr.gameObject.GetComponent<VideoPlayer>().clip = p1HighKick;
                    attackSr.gameObject.GetComponent<VideoPlayer>().Play();
                    rawAttack.SetActive(true);
                    yield return new WaitForSeconds(3);
                    dealDamage(1,pTwoHP,12);
                    break;

                    case 5:
                    attackSr.gameObject.GetComponent<VideoPlayer>().clip = p1Special;
                    attackSr.gameObject.GetComponent<VideoPlayer>().Play();
                    rawAttack.SetActive(true);
                    yield return new WaitForSeconds(5);
                    dealDamage(1,pTwoHP,25);
                    break;
                }
            }

            // miss p1
            else
            {
                switch (attackNumber)
                {
                    case 1:
                    Debug.Log("");
                    attackSr.gameObject.GetComponent<VideoPlayer>().clip = mp1LowPunch;
                    attackSr.gameObject.GetComponent<VideoPlayer>().Play();
                    rawAttack.SetActive(true);
                    yield return new WaitForSeconds(2);
                    rawAttack.SetActive(false);
                    break;

                    case 2:
                    attackSr.gameObject.GetComponent<VideoPlayer>().clip = mp1HighPunch;
                    attackSr.gameObject.GetComponent<VideoPlayer>().Play();
                    rawAttack.SetActive(true);
                    yield return new WaitForSeconds(3);
                    rawAttack.SetActive(false);
                    break;

                    case 3:
                    attackSr.gameObject.GetComponent<VideoPlayer>().clip = mp1LowKick;
                    attackSr.gameObject.GetComponent<VideoPlayer>().Play();
                    rawAttack.SetActive(true);
                    yield return new WaitForSeconds(2);
                    rawAttack.SetActive(false);
                    break;

                    case 4:
                    attackSr.gameObject.GetComponent<VideoPlayer>().clip = mp1HighKick;
                    attackSr.gameObject.GetComponent<VideoPlayer>().Play();
                    rawAttack.SetActive(true);
                    yield return new WaitForSeconds(3);
                    rawAttack.SetActive(false);
                    break;

                    case 5:
                    attackSr.gameObject.GetComponent<VideoPlayer>().clip = mp1Special;
                    attackSr.gameObject.GetComponent<VideoPlayer>().Play();
                    rawAttack.SetActive(true);
                    yield return new WaitForSeconds(5);
                    rawAttack.SetActive(false);
                    break;
                }
            }
        }
        
        else
        {
           if (x <= accuracy)
                {
                    switch (attackNumber)
                    {
                        case 1:
                        attackSr.gameObject.GetComponent<VideoPlayer>().clip = p2LowPunch;
                        attackSr.gameObject.GetComponent<VideoPlayer>().Play();
                        rawAttack.SetActive(true);
                        yield return new WaitForSeconds(2);
                        dealDamage(2,pOneHP,3);
                        break;

                        case 2:
                        attackSr.gameObject.GetComponent<VideoPlayer>().clip = p2HighPunch;
                        attackSr.gameObject.GetComponent<VideoPlayer>().Play();
                        rawAttack.SetActive(true);
                        yield return new WaitForSeconds(3);
                        dealDamage(2,pOneHP,8);
                        break;

                        case 3:
                        attackSr.gameObject.GetComponent<VideoPlayer>().clip = p2LowKick;
                        attackSr.gameObject.GetComponent<VideoPlayer>().Play();
                        rawAttack.SetActive(true);
                        yield return new WaitForSeconds(2);
                        dealDamage(2,pOneHP,6);
                        break;

                        case 4:
                        attackSr.gameObject.GetComponent<VideoPlayer>().clip = p2HighKick;
                        attackSr.gameObject.GetComponent<VideoPlayer>().Play();
                        rawAttack.SetActive(true);
                        yield return new WaitForSeconds(3);
                        dealDamage(2,pOneHP,12);
                        break;

                        case 5:
                        attackSr.gameObject.GetComponent<VideoPlayer>().clip = p2Special;
                        attackSr.gameObject.GetComponent<VideoPlayer>().Play();
                        rawAttack.SetActive(true);
                        yield return new WaitForSeconds(5);
                        dealDamage(2,pOneHP,25);
                        break;
                    }
                }
            
            else
                {
                    switch (attackNumber)
                    {
                        case 1:
                        attackSr.gameObject.GetComponent<VideoPlayer>().clip = mp2LowPunch;
                        attackSr.gameObject.GetComponent<VideoPlayer>().Play();
                        rawAttack.SetActive(true);
                        yield return new WaitForSeconds(2);
                        rawAttack.SetActive(false);
                        break;

                        case 2:
                        attackSr.gameObject.GetComponent<VideoPlayer>().clip = mp2HighPunch;
                        attackSr.gameObject.GetComponent<VideoPlayer>().Play();
                        rawAttack.SetActive(true);
                        yield return new WaitForSeconds(3);
                        rawAttack.SetActive(false);
                        break;

                        case 3:
                        attackSr.gameObject.GetComponent<VideoPlayer>().clip = mp2LowKick;
                        attackSr.gameObject.GetComponent<VideoPlayer>().Play();
                        rawAttack.SetActive(true);
                        yield return new WaitForSeconds(2);
                        rawAttack.SetActive(false);
                        break;

                        case 4:
                        attackSr.gameObject.GetComponent<VideoPlayer>().clip = mp2HighKick;
                        attackSr.gameObject.GetComponent<VideoPlayer>().Play();
                        rawAttack.SetActive(true);
                        yield return new WaitForSeconds(3);
                        rawAttack.SetActive(false);
                        break;

                        case 5:
                        attackSr.gameObject.GetComponent<VideoPlayer>().clip = mp2Special;
                        attackSr.gameObject.GetComponent<VideoPlayer>().Play();
                        rawAttack.SetActive(true);
                        yield return new WaitForSeconds(5);
                        rawAttack.SetActive(false);
                        break;
                    }
                }
          

        }
    }

    IEnumerator healthChecker()
    {
        if (pOneHP <= 0)
        {
            dataHandler.vPasser.winner = 2;
            yield return new WaitForSeconds(3);
            SceneManager.LoadScene(3);
        }

        if (pTwoHP <= 0)
        {
            dataHandler.vPasser.winner = 1;
            yield return new WaitForSeconds(3);
            SceneManager.LoadScene(3);
        }

    }

}
