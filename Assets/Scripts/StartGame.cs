using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{

    public int gameMode;

	void Start () {
        gameMode = 0;	
	}

	void Update () {
		
	}

    public void SelectWorld()
    {
        gameMode = 1;
        CallStartGame(gameMode);
    }

    public void SelectEurope()
    {
        gameMode = 2;
        CallStartGame(gameMode);
    }

    public void CallStartGame(int gameMode)
    {
        SceneManager.LoadScene(gameMode);
    }
}
