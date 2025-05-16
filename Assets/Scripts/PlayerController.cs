using System.Collections;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 20.0f;
    private float turnSpeed = 45.0f;

    private float horizontalInput;
    private float forwardInput;

    private GameManager gameManager;
    private GameObject flagTrigger;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        flagTrigger = GetComponent<GameObject>();
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        if (flagTrigger)
        {
            gameManager.lap += 1;
        }
    }

}
