using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class TimeManager : MonoBehaviour
{
    public float timeCount;

    [SerializeField] TextMeshProUGUI timeText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        timeText.text = "Time: ";
    }

    // Update is called once per frame
    void LateUpdate() //creates timer that counts up, splitting seconds and minutes 
    {
        timeCount += Time.deltaTime;
        int minutes = Mathf.FloorToInt(timeCount / 60);
        int seconds = Mathf.FloorToInt(timeCount % 60);
        timeText.text = string.Format("Time: {0:00}:{1:00}", minutes, seconds);
    }

    
}
