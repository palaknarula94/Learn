using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerJump : MonoBehaviour
{
    private Rigidbody rb;
    public float force = 10f;
    public float gravityModifier ;

    public bool isGround = true;
    public bool gameOver = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Physics.gravity *=gravityModifier;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isGround )
        {
            rb.AddForce(Vector3.up * force, ForceMode.Impulse);
            isGround = false;
        }

     }

    public void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Ground"))
            isGround = true;
        else if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("gameoover");
            gameOver = true;
        }
            

    }
}
