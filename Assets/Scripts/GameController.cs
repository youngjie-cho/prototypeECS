﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public characterController Sam;
    public player player;
    public Animator animator;
    public Loading_Scenes loader;
    

    // Start is called before the first frame update

    
    
    // win situation
    public void winSituation()
    {
       if(Sam.clue_collect && Sam.obj_complete){
           loader.Load_Next_Scene();
       }

    }

    //lose situation 1 : falling down
    //lost situation 2 (on top of this code) : time's up
    public void loseSituation()
    {
        if(Sam.ourRigidbody.position.y < -20){
            stoppingTheGame();
            Sam.ourRigidbody.constraints = RigidbodyConstraints2D.FreezePosition;
        }
    }

    public void stoppingTheGame()
    {
        player.enabled = false;
        animator.enabled = false;
    }

    public void startingTheGame(){
        player.enabled = true;
        animator.enabled = true;
    }
}
