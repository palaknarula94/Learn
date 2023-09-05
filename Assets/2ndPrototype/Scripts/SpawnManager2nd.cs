using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager2nd : MonoBehaviour
{

    public GameObject[] spawnObjs;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S))
        {
            int randomLength = Random.Range(0, spawnObjs.Length);
            Instantiate(spawnObjs[randomLength],new Vector3(0,0,20), spawnObjs[randomLength].transform.rotation);
        }

    }
}
