using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField]
    public GameObject player;

    public void ChangeFloor(Floor f)
    {
        player.transform.position = f.lifts[Random.Range(0,f.lifts.Count)].transform.position;
    }
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectsWithTag("Player")[0];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
