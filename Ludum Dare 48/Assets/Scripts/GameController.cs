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
        visitFloor(f.number); 
    }

    public void visitFloor(int n){
        GameObject.FindGameObjectsWithTag("Section")[0].GetComponent<Section>().checkFloor(n);
        GameObject.FindGameObjectsWithTag("UIController")[0].GetComponent<UIController>().ShowLevelText("Уровень "+ n + "пройден.");
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
