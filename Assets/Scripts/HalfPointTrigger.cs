using UnityEngine;

public class HalfPointTrigger : MonoBehaviour
{
    private PlayerController playerController;

    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision other)
    {
        if (gameObject.CompareTag("Player"))
        {
            playerController.isHalfPoint = true;
        }
    }
}
