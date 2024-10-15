using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ImpGUI : MonoBehaviour
{
    public Texture2D buttonImage;
    public Vector2 position;
    public Vector2 size;
    public string labelText = "Choose Your Character!";

    private void OnGUI()
    {
        GUI.Box(new Rect(15, 20, 1430, 680), "Change Stats");
        GUI.Label(new Rect(950, 160, 200, 150), labelText);
        if (GUI.Button(new Rect(50, 100, 200, 150), "Akane Kurokawa"))
        {
            labelText = "Name: Akane Kurokawa \nAttack: 10 \nDefence: 30 \nSpeed: 25 \nLuck: 300 \nIntelligence: 500 \nSpecial: 1000";
        }

        if (GUI.Button(new Rect(50, 300, 200, 150), "Sakura Kasugano"))
        {
            labelText = "Name: Sakura Kasugano \nAttack: 500 \nDefence: 300 \nSpeed: 50 \nLuck: 500 \nIntelligence: 450 \nSpecial: 950";
        }

        if (GUI.Button(new Rect(50, 500, 200, 150), "Yuffie Kisaragi"))
        {
            labelText = "Name: Yuffie Kisaragi \nAttack: 300 \nDefence: 100 \nSpeed: 100 \nLuck: 1000 \nIntelligence: 400 \nSpecial: 900";
        }
    }
}
