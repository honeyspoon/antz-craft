﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour {

    private bool upgradesOn = false;

    public void Start() {
        UnityEngine.Debug.Log("Start of program");
    }

    public void showUpgrades() {
        UnityEngine.Debug.Log("Button Click");
        SceneManager.LoadScene("Upgrades", LoadSceneMode.Additive);


    }
}