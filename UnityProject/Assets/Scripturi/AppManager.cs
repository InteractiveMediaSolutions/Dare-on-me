using UnityEngine;
using System.Collections;
using Microsoft.Azure.Engagement.Unity;
using System;

public class AppManager : MonoBehaviour {




    // Use this for initialization
    void Start()
    {


        EngagementReach.Initialize();
        EngagementReach.Initialize();
        EngagementAgent.StartActivity("Main");

    }

// Update is called once per frame
void Update () {

        

    }



}
