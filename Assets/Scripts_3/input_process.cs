using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class input_process : MonoBehaviour
{
    float speed = 5f;
    public GameObject myCharacter;

    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        float moveH = Input.GetAxis("Horizontal");
        float moveV = Input.GetAxis("Vertical");
        float jump = Input.GetAxis("Jump");
        myCharacter.transform.Translate(new Vector3 (moveH, jump,moveV) * speed * Time.deltaTime);

    }

    void Update()
    {
        
    }
}
