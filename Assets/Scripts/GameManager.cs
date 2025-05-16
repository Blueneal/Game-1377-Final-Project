using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public float timeCount;
    public int playerLap;
    public int aiLap;
    public int lap;

    //Text for lap time and score
    [SerializeField] TextMeshProUGUI lapText;
    [SerializeField] TextMeshProUGUI timeText;

    public bool isGameActive; //sets whether the game is in play

    private PlayerController playerController;
    public GameObject flagTrigger;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        flagTrigger.SetActive(true);
        lapText.text = "Lap: " + lap;
        timeText.text = "Time: ";
        isGameActive = true;
    }

    // Update is called once per frame
    void Update()
    {
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
