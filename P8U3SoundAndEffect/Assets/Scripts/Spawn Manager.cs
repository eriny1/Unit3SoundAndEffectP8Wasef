using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclPrefab;
    private Vector3 spawnpos = new Vector3(25, 0, 0);
    private float startDelay = 2;
    private float repearRate = 2;
    private PlayerController PlayerControllerScript;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repearRate);
        PlayerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void SpawnObstacle()
    {
        if (PlayerControllerScript.gameOver == false)
        {
            Instantiate(obstaclPrefab, spawnpos, obstaclPrefab.transform.rotation);
        }

    }
}
