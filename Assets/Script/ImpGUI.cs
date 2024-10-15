using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ImpGUI : MonoBehaviour
{
    public Texture2D buttonImage;
    public Vector2 position;
    public Vector2 size;

    private void OnGUI()
    {
        GUI.Box(new Rect(15, 20, 1430, 680), "Change Stats");
        if (GUI.Button(new Rect(50, 100, 200, 150), "Option 1"))
        {

        }

        if (GUI.Button(new Rect(50, 300, 200, 150), "Option 2"))
        {

        }
        
        if (GUI.Button(new Rect(50, 500, 200, 150), "Option 3"))
        {

        }
    }
}
