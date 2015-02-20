using UnityEngine;
using System.Collections;

public class EcoCityCraftVoter : MonoBehaviour 
{
    // Copyright Jamie Sinn 2014 - Sinn Development
    // All Rights Reserved.
    
    private static float Width = Screen.width;
    private static float Height = Screen.height / 8;
    private static float ButtonStart = Screen.height / 6;
    public Texture Background;

    public static Rect BG = new Rect(0, 0, Width, Screen.height);
    public static Rect Forums = new Rect(0, ButtonStart +  Height, Width, Height);
    public static Rect V1 = new Rect(0, ButtonStart + 2 * Height + 5, Width, Height);
    public static Rect V2 = new Rect(0, ButtonStart + 3 * Height + 5, Width, Height);
    public static Rect V3 = new Rect(0, ButtonStart + 4 * Height + 5, Width, Height);
    public static Rect SinnDev = new Rect(0, ButtonStart + 5 * Height + 15, Width, Height);

    void OnGUI()
    {
        GUI.contentColor = Color.white;
        GUI.backgroundColor = Color.white;
        GUIStyle myStyle = new GUIStyle();
        myStyle.fontSize = 50;
        
        GUI.DrawTexture(BG, Background);
    
        
        if (GUI.Button(Forums, "EcoCityCraft Forums", myStyle))
        {
            Application.OpenURL("http://ecocitycraft.com");
        }
        if (GUI.Button(V1, "Vote Site 1", myStyle))
        {
            Application.OpenURL(VoteSites.Vote1);
        }
        if (GUI.Button(V2, "Vote Site 2", myStyle))
        {
            Application.OpenURL(VoteSites.Vote2);
        }
        if (GUI.Button(V3, "Vote Site 3", myStyle))
        {
            Application.OpenURL(VoteSites.Vote3);
        }
        if (GUI.Button(SinnDev, "Sinn Development", myStyle))
        {
            Application.OpenURL("http://sinndevelopment.com");
        }
        
    }
}
