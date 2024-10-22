using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExerciseGUI : MonoBehaviour
{
    /*COMMENTS
     if (!togglebool = False)
     if (togglebool = True)
    */

    /*private string textFieldString = "Enter Your Name!";
        void OnGUI()
        {
            textFieldString = GUI.TextField(new Rect(30, 30, 150, 30), textFieldString);
            if (GUI.Button(new Rect(40,70,150,150), "walangpasok")) 
                {
                    Debug.Log(textFieldString);
                }
        }
    */
    private bool toggleBool = true;
        void OnGUI()
        {
            toggleBool = GUI.Toggle(new Rect(25, 25, 100, 30), toggleBool, "Toggle");
        if (toggleBool)
            Debug.Log("toggleBool is true");
        else
            Debug.Log("togglebool is false");
    }
}
