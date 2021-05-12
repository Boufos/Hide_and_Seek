using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Patrol : MonoBehaviour
{
    [SerializeField] Vector3[] transformPoints;
    public float speed;
    public float rotate;
    int i = 0;

    void Update()
    {
        
        if(i>transformPoints.Length-1)
        {
            i=0;
        }
        transform.position = Vector3.MoveTowards(transform.position, transformPoints[i], speed*Time.deltaTime);
        if(Vector3.Distance(transform.position, transformPoints[i])<0.2f)
        {
           transform.Rotate(new Vector3(0, rotate, 0));
            i++;
        }
       
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            
            SceneManager.LoadScene("MenuLose");
        }
    }

}
