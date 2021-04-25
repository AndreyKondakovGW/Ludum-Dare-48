using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    private float speed = 2.0F;

    [SerializeField]
    private Transform target;

    private void Awake()
    {
        //if (!target) target = FindObjectOfType<Character>().transform;

    }

    private void Update()
    {
        Vector3 position = target.position;position.y = position.y + 2;     position.z = -2F;
        transform.position = Vector3.Lerp(transform.position, position, speed * Time.deltaTime);
    }

    public void ChangeCharacter(Transform newCharacter)
    {
        target = newCharacter;    
    }
}
