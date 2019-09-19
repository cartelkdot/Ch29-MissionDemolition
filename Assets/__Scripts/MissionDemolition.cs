using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum GameMode
{
    idle,
    playing,
    levelEnd

}

public class MissionDemolition : MonoBehaviour {
    static private MissionDemolition S; // a private Singleton

    [Header("Set in Inspector")]
    public Text uitLevel;
    public Text uitShots;
    public Text uitButton;
    public Vector3 castlePos;
    public GameObject castles;

    [Header("Set Dynamically")]
    public int level;
    public int levelMax;
    public int shotsTaken;
    public GameObject castle;
    public GameMode mode = GameMode.idle;
    public string showing = "Show Slingshot";

	// Use this for initialization
	void Start ()
    {

    }
	
	void StartLevel()
    {
        // Get rid of the old castle if one exists
 
    }

    void UpdateGUI()
    {

    }

    void Update()
    {


    }

    void NextLevel()
    {

    }

    public void SwitchView(string eView = "")
    {

    }

    // Static method that allows code anywhere to increment shotsTaken
    public static void ShotFired()
    {

    }
}
