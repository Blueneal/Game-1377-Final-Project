using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public int timeCount;
    public int playerLap;
    public int aiLap;
    public int lap;

    //Text for lap time and score
    public TextMeshProUGUI lapText;
    public TextMeshProUGUI timeText;

    public bool isGameActive; //sets whether the game is in play

    private PlayerController playerController;
    public GameObject halfPointTrigger;
    public GameObject flagTrigger;
    public GameObject countDown;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        isGameActive = false;
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
        halfPointTrigger.SetActive(true);
        flagTrigger.SetActive(true);
        StartCoroutine(CountDown());
        lapText.text = "Lap: " + lap;
        timeText.text = "Lap Time: " + timeCount;
        isGameActive = true;
    }

    // Update is called once per frame
    void Update() //adds a count to the time while also checking to see if the game is over
    {
        timeCount = +1;
        GameOver();
    }

    public void GameOver()
    {
        if (playerLap == 3 || aiLap == 3)
        {
            isGameActive = false;
        }
    }

    //Coroutine to play a countdown at the beginning of the game
    IEnumerator CountDown()
    {
        yield return new WaitForSeconds(1);
        countDown.GetComponent<Text>().text = "3";
        yield return new WaitForSeconds(1);
        countDown.GetComponent<Text>().text = "2";
        yield return new WaitForSeconds(1);
        countDown.GetComponent<Text>().text = "1";
        yield return new WaitForSeconds(1);
        countDown.GetComponent<Text>().text = "GO!";
    }
    
}
