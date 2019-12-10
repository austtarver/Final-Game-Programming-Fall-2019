using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class scenes : MonoBehaviour
{
	public void NextScene()
	{
		SceneManager.LoadScene("2HighScores");
	}
    public void StartPlay()
    {
        SceneManager.LoadScene("3Game");
    }
    public void StopPlay()
    {
        SceneManager.LoadScene("4Exit");
    }
    public void PlayAgain()
    {
        SceneManager.LoadScene("1Intro");
    }
    public void ExitGame()
    {
        // exit the game for real play
        //Application.Quit();
        //does not work in Unity since it would  lose all settings. so:
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
