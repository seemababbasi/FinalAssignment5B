﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Mlagent : MonoBehaviour
{
    int ScreenNumber;
    public void penguin()
    {
        
            ScreenNumber = 3;
            SceneManager.LoadScene(ScreenNumber);
       
    }

    public void humingBird()
    {      
            ScreenNumber = 4;
            SceneManager.LoadScene(ScreenNumber);      
    }
    public void MovetoMainMenu()
    {
        
            ScreenNumber = 1;
            SceneManager.LoadScene(ScreenNumber);
        
    }

    public void moveTomlagent()
    {
        
            ScreenNumber = 2;
            SceneManager.LoadScene(ScreenNumber);  
    }

    public void gotoPalindrome()
    {

        ScreenNumber = 6;
        SceneManager.LoadScene(ScreenNumber);
    }

    public void gotoMatching()
    {

        ScreenNumber = 8;
        SceneManager.LoadScene(ScreenNumber);
    }

    public void returnToComputationalModel()
    {

        ScreenNumber = 5;
        SceneManager.LoadScene(ScreenNumber);
    }

    public void moveToMLAgent()
    {

        ScreenNumber = 5;
        SceneManager.LoadScene(ScreenNumber);
    }
    // Move to Move to roll ball game..
    // This is version of previous game of 4b
    public void MoveToRollBallGame()
    {
        ScreenNumber = 7;
        SceneManager.LoadScene(ScreenNumber);
    }


    public void MoveToPalindromeScene()
    {
        ScreenNumber = 6;
        SceneManager.LoadScene(ScreenNumber);
    }






}
