using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{

    [SerializeField]
    float speed;

    private Animator animator;

    private Boolean isMoving;

    // Start is called before the first frame update
    void Start()
    {
        isMoving = true;
    }

    // Update is called once per frame
    void Update()
    {
        float posX = transform.position.x - speed * Time.deltaTime;
        transform.position = new Vector3(posX, transform.position.y, -Camera.main.transform.position.z);
   
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Tower")
        {
            //TODO: xử lý attack trụ
        } else if(collision.gameObject.tag == "Hero")
        {
            //TODO: xử lý attack hero
        }
    }
}
