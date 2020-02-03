﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateController : MonoBehaviour
{
    StateMachine stateMachine;
    IState scene1;
    // Start is called before the first frame update
    void Start() {
        stateMachine = new StateMachine();
        scene1 = GameObject.Find("/ScenenOneState").GetComponent<SceneOneState>();
        Debug.Log(scene1);
        stateMachine.ChangeState(scene1);
        stateMachine.RunState();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Gets called by the state of the end of the state to change to next state
    void nextState()
    {

    }
}
