using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class keepData : MonoBehaviour
{
	
	
	public static float PlayerSize;
	public static string PlayerName;


	public Slider SizeSlider;
	
	
	public InputField PlayerNameInput;

	private void Awake()
	{
		DontDestroyOnLoad(this.gameObject); //don't destroy when new scene is loaded
	}
	private void Update()
	{
		//Debug.Log(PlayerName + " has " + PlayerLives + " lives and " + PlayerSpeed + " speed and score of " + PlayerScore);
	}

	
	

	public void ChangeSize()
	{
		PlayerSize = SizeSlider.value;
	}

	public void SetName()
	{
		PlayerName = PlayerNameInput.text;
	}
}
