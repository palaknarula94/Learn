using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject prefab;
    public Vector3 pos = new Vector3(20f, 0, 0);

    private float startTime = 2f;
    private float repeatedDelay = 3f;

    private PlayerControllerJump playerController;
    // Start is called before the first frame update
    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerControllerJump>();
        InvokeRepeating("spawnObstacle", startTime, repeatedDelay);
    }

   void spawnObstacle()
    {
        if(playerController.gameOver==false)
         Instantiate(prefab, pos, prefab.transform.rotation);
    }
}
