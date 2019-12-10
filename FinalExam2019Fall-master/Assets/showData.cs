using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class showData : MonoBehaviour
{
	
	public Text Size;
	
	public Text Score;
	public Text Lives;
	public Text Name;


	private void Awake()
	{
		
		Size.text = "Size: " + keepData.PlayerSize.ToString();

		Name.text = keepData.PlayerName.ToString();

		Score.text = "Score: " + ScoreKeeper.newScore.ToString() ;
		Lives.text = "Lives: " + LivesTracker.lives.ToString();

	}

	// Update is called once per frame
	void Update()
    {
		Score.text ="Score: " +  ScoreKeeper.newScore.ToString();
		Lives.text ="Lives: " + LivesTracker.lives.ToString();
	}
}
