using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Note : MonoBehaviour   
{
    private BoxCollider2D _box;
    [SerializeField] GameObject textBox;
    [SerializeField] GameObject note;
    void Start()
    {
            textBox.SetActive(false);
            note.SetActive(false);
          _box = GetComponent<BoxCollider2D>();
    }

   void OnTriggerEnter2D(Collider2D other)
    {
      textBox.SetActive(true);
      
    }
      void OnTriggerStay2D(Collider2D other)
    {
        if(Input.GetKeyDown("e"))
        {
            note.SetActive(true);
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
       textBox.SetActive(false);
    }
    void Update()
    {
        
    }
}
