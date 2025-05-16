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
        timeText.text = "Lap Time: " + timeCount;
        isGameActive = true;
    }

    // Update is called once per frame
    void Update() //adds a count to the time while also checking to see if the game is over
    {
        timeText.text = "Lap Time: " + timeCount;
        GameOver();
    }

    public void GameOver()
    {
        if (playerLap == 3 || aiLap == 3)
        {
            isGameActive = false;
        }
    }

    void LateUpdate()
    {
            timeCount -= Time.deltaTime;
            int minutes = Mathf.FloorToInt(timeCount / 60);
            int seconds = Mathf.FloorToInt(timeCount % 60);
            timeText.text = string.Format("{0:00}:{1:00}");
    }
}
