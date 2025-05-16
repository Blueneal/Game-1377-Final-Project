using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerMover : MonoBehaviour
{
    private float speed = 10.0f;

    private float horizontalInput;

    public bool isGameActive;
    public bool isPlayerDead = false;

    [SerializeField] TextMeshProUGUI gameoverText;
    [SerializeField] Image gameoverBackground;

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
        gameoverText.gameObject.SetActive(true);
        gameoverBackground.gameObject.SetActive(true);
    }
}
