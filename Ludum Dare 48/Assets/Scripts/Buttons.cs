using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{
    private BoxCollider2D _box;
    [SerializeField] Text textBox;
    void Start()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        textBox.text = "Нажмите e чтобы прочитать";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
