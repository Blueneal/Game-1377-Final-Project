using UnityEngine;
using TMPro;

public class TimeManager : MonoBehaviour
{
    public float timeCount;

    private AudioSource gameAudio;

    [SerializeField] TextMeshProUGUI timeText;
    [SerializeField] TextMeshProUGUI gameOverText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timeText.text = "Time: ";
        gameAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void LateUpdate() //creates timer that counts up, splitting seconds and minutes 
    {
        timeCount += Time.deltaTime;
        int minutes = Mathf.FloorToInt(timeCount / 60);
        int seconds = Mathf.FloorToInt(timeCount % 60);
        timeText.text = string.Format("Time: {0:00}:{1:00}", minutes, seconds);
    }

    public void GameOver()
    {
        gameOverText.gameObject.SetActive(true);
    }
}
