using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager instance { get { return _instance; } }
    private static UIManager _instance;

    public GameObject pause;
    public GameObject gameOver;
    public GameObject levelComplete;
    public GameObject levelUp;

    public Image health;
    public Image mana;
    public Image fireballCd;
    public Image empCd;
    public Image energyWallCd;
    public Image clonCd;

    public Text score;
    public Text gameTimer;
    public Text killCount;
    public Text medKits;
    public Text pointsLeft;
    public Text noMana;

    // Use this for initialization
    void Awake ()
    {
        if (_instance == null)
            _instance = this;

        pause.SetActive(false);
        gameOver.SetActive(false);
        levelComplete.SetActive(false);
        levelUp.SetActive(false);
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}

}
