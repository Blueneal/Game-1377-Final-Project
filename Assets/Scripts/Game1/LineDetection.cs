using TMPro;
using UnityEngine;
using UnityEngine.LowLevel;

public class LineDetection : MonoBehaviour
{
    private GameManager gameManager;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Line Crossed");
        gameManager.isLineCrossed = true;
    }
}
