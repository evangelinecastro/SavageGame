using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dataHandler: MonoBehaviour
{   
    public static dataHandler vPasser;
    public string pName1;
    public string pName2;
    public int pHealth;
    public int winner;

    private void Awake()
    {
        if (vPasser == null)
        {
            vPasser = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

