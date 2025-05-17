using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerMover : MonoBehaviour
{
    //Note: Player Controller has been made a more central code for ease and neccassary solution

    private float speed = 10.0f;

    private float horizontalInput;

    public bool isGameActive;
    public bool isPlayerDead = false;

    [SerializeField] TextMeshProUGUI gameoverText;
    [SerializeField] TextMeshProUGUI exitText;
    [SerializeField] Image gameoverBackground;
    [SerializeField] Button restartButton;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameoverText.gameObject.SetActive(false);
        gameoverBackground.gameObject.SetActive(false);
        isGameActive = true;

    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);

    }

    private void OnTriggerEnter(Collider other)
    {
        GameOver();
        Destroy(gameObject);
        Destroy(other.gameObject);
        isPlayerDead = true;
    }
    public void GameOver()
    {
        isGameActive = false;
        Time.timeScale = 0; //stops the counter from going up
        gameoverText.gameObject.SetActive(true);
        exitText.gameObject.SetActive(true);
        gameoverBackground.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true);
    }
}
