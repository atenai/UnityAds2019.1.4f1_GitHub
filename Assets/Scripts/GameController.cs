using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Advertisements;

public class GameController : MonoBehaviour
{

    //private string gameIDGoogleplay = "4781103", gameIDAppstore = "4781102";
    void Start()
    {
        //Advertisement.Initialize(gameIDGoogleplay, testMode: true);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ShowAd()
    {
        if (Advertisement.IsReady())
        {
            Advertisement.Show();
        }
    }
}

