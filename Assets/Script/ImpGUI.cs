using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ImpGUI : MonoBehaviour
{
    public Texture2D buttonImage;
    public Vector2 position;
    public Vector2 size;
    public string text = "Choose Your Character!";
    private int attackp1 = 10;
    private int attackp2 = 500;
    private int attackp3 = 300;
    private int defensep1 = 30;
    private int defensep2 = 300;
    private int defensep3 = 100;
    private int speedp1 = 25;
    private int speedp2 = 50;
    private int speedp3 = 100;
    private int luckp1 = 300;
    private int luckp2 = 500;
    private int luckp3 = 1000;
    private int intelligencep1 = 500;
    private int intelligencep2 = 450;
    private int intelligencep3 = 400;
    private int specialp1 = 1000;
    private int specialp2 = 950;
    private int specialp3 = 900;
    private void OnGUI()
    {
        GUI.Box(new Rect(15, 20, 1430, 680), "Change Stats");
        GUI.Label(new Rect(950, 160, 200, 150), text);
        if (GUI.Button(new Rect(50, 100, 200, 150), "Option 1"))
        {
            text = $"Name: Akane Kurokawa \nAttack: {attackp1} \nDefence: {defensep1} \nSpeed: {speedp1} \nLuck: {luckp1} \nIntelligence: {intelligencep1} \nSpecial: {specialp1}";
        }

        if (GUI.Button(new Rect(50, 300, 200, 150), "Option 2"))
        {
            text = "Name: Sakura Kasugano \nAttack: 500 \nDefence: 300 \nSpeed: 50 \nLuck: 500 \nIntelligence: 450 \nSpecial: 950";
        }

        if (GUI.Button(new Rect(50, 500, 200, 150), "Option 3"))
        {
            text = "Name: Yuffie Kisaragi \nAttack: 300 \nDefence: 100 \nSpeed: 100 \nLuck: 1000 \nIntelligence: 400 \nSpecial: 900";
        }
    }
}
