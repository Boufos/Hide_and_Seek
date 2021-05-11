using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroController : MonoBehaviour
{
    public float speed;
    Rigidbody _rigid;
    [SerializeField] GameObject parentTransform;
    void Start()
    {
        _rigid = GetComponent<Rigidbody>();
        _rigid.transform.position = parentTransform.transform.position;
    }

    void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        _rigid.velocity = new Vector3(moveX, 0, moveZ) * speed;
    }

 
}
