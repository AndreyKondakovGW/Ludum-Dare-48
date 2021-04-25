using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private BoxCollider2D _box;
    [SerializeField] GameObject textBox;

    void Start()
    {
         _box = GetComponent<BoxCollider2D>();
    }

   void OnTriggerStay2D(Collider2D collision)
    {
        textBox.SetActive(true);
        
    }
    void OnTriggerExit2D(Collider2D other)
    {
       textBox.SetActive(false);
    }
    void Update()
    {
        
    }
}
