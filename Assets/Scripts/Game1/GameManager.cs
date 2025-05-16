using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.LowLevel;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public float timeCount;
    public int aiLap;

    //Text for lap time and score
    [SerializeField] TextMeshProUGUI timeText;
    [SerializeField] TextMeshProUGUI lapText;

    public bool isGameActive; //sets whether the game is in play

    private LineDetection lineDetection;
    //public GameObject flagTrigger;

    public int playerLap;
    public bool isLineCrossed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerLap = 0;
        lapText.text = "Lap: " + playerLap;
        timeText.text = "Time: ";
        isGameActive = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (isLineCrossed == true)
        {
            playerLap += 1;
            lapText.text = "Lap: " + playerLap;
            isLineCrossed = false;
        }
        GameOver();
    }

    public void GameOver()
    {
        if (playerLap == 3 || aiLap == 3)
        {
            isGameActive = false;
        }
    }
    
    void LateUpdate() //creates timer that counts up, splitting seconds and minutes 
    {
        timeCount += Time.deltaTime;
        int minutes = Mathf.FloorToInt(timeCount / 60);
        int seconds = Mathf.FloorToInt(timeCount % 60);
        timeText.text = string.Format("Time: {0:00}:{1:00}", minutes, seconds);
    }
    
}
