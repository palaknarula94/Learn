using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{

    public float speed = 2f;
    private PlayerControllerJump playerController;
    private float leftBound = -15f;

    // Start is called before the first frame update
    void Start()
    {
        playerController =GameObject.Find("Player").GetComponent<PlayerControllerJump>();
    }

    // Update is called once per frame
    void Update()
    {
        if(playerController.gameOver==false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }

        if(transform.position.x<leftBound && gameObject.CompareTag("Obstacle"))
            {
            Destroy(gameObject);
        }
       
    }
}
