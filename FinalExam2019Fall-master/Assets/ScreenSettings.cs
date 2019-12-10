using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScreenSettings : MonoBehaviour
{


	public Dropdown mySpeedDropdown;
    public Dropdown MyTimerDropDown;
    
   
    public static string speed = "slow";
    public static float gameModeTimer = 30f;

    void Update()
    {
       

        switch (MyTimerDropDown.value)
        {
            case 1:
                gameModeTimer = 20f;
                break;
            case 2:
                gameModeTimer = 40f;
                break;
            case 3:
                gameModeTimer = 999999999999999999f;
                break;
            default:
                gameModeTimer = 20f;
                break;
        }

		switch (mySpeedDropdown.value)
		{
			case 1:
				speed = "slow";
				break;
			case 2:
				speed = "fast";
				break;

		}

    }

   

    public void AdjustSpeed(string newSpeed)
    {
        speed = newSpeed;
        Debug.Log(speed);
    }
}
