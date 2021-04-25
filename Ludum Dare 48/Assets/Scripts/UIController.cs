using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    [SerializeField]
    public GameObject DoorNotification;
    [SerializeField]
    public GameObject NoteNotification;

    public void ShowDoorNotification(){
        DoorNotification.SetActive(true);
    }

    public void CloseDoorNotification(){
        DoorNotification.SetActive(false);
    }

    public void ShowNoteNotification(){
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
