using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    [SerializeField]
    public GameObject DoorNotification;
    [SerializeField]
    public GameObject NoteNotification;
    [SerializeField]
    public GameObject LevelNotification;

    public void ShowDoorNotification(){
        DoorNotification.SetActive(true);
    }

    public void CloseDoorNotification(){
        DoorNotification.SetActive(false);
    }

    public void ShowLevelText(string text){
        LevelNotification.GetComponent<Text>().text = text;
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
