using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleAction : MonoBehaviour
{
    public Button MyButton;
 
    public Toggle MyToggle;

    //need to connect to ToggleAction.Toggle_Changed(), not ToggleAction.Toggle_Changed(bool). 
    public void Toggle_Changed(bool newValue)
    {
        MyButton.enabled = newValue;
        
      
      

    }

}
