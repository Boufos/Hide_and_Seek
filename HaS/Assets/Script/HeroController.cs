using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HeroController : MonoBehaviour
{
    public float speed;
    Rigidbody _rigid;
    CharacterController ch;
    [SerializeField] GameObject parentTransform;
    Vector3 moveVector;
    void Start()
    {
        SaveData.currentLvl = SceneManager.GetActiveScene().buildIndex;
        _rigid = GetComponent<Rigidbody>();
        ch = GetComponent<CharacterController>();
        _rigid.transform.position = parentTransform.transform.position;
    }

    void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        moveVector = Vector3.zero;
        moveVector.x = Input.GetAxis("Horizontal") * speed;
        moveVector.z = Input.GetAxis("Vertical") * speed;
        if(Vector3.Angle(Vector3.forward, moveVector) >1f || Vector3.Angle(Vector3.forward, moveVector) ==0)
        {
            Vector3 direct = Vector3.RotateTowards(transform.forward, moveVector, speed, 0.0f);
            transform.rotation = Quaternion.LookRotation(direct);
        }
        ch.Move(moveVector * speed);


    }

 
}
