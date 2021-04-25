using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lift : MonoBehaviour
{
    public bool attached = false;
    public Lift conected;

    public void attachedTo(Lift l){
        conected = l;
        attached = true;
        SpriteRenderer m_SpriteRenderer = GetComponent<SpriteRenderer>();
        m_SpriteRenderer.color = Color.blue;
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
