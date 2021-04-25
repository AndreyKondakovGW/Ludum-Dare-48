using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    bool enter = false;
    private BoxCollider2D _box;
    private UIController controller;
    private GameController gameController;
    [SerializeField] GameObject textBox;

    void Start()
    {
        _box = GetComponent<BoxCollider2D>();
        controller = GameObject.FindGameObjectsWithTag("UIController")[0].GetComponent<UIController>();
        gameController = GameObject.FindGameObjectsWithTag("GameController")[0].GetComponent<GameController>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        enter = true;
        controller.ShowDoorNotification();
      
    }

    void OnTriggerExit2D(Collider2D other)
    {
        enter = false;
        controller.CloseDoorNotification();
       //textBox.SetActive(false);
    }
    void Update()
    {
        if(Input.GetKeyDown("e") && enter)
        {
            Lift lift = gameObject.GetComponent<Lift>();
            if (lift.attached){
                gameController.ChangeFloor(lift.conected);
            }
            
        }
    }
}
