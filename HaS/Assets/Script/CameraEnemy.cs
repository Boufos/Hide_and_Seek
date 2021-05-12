using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraEnemy : MonoBehaviour
{
    public float time;
    private bool sw =true;
    [SerializeField] GameObject laser;

    private void Start()
    {
        Invoke("CloseCamera", 2f);
    }

    void CloseCamera()
    {
        sw = !sw;
        laser.SetActive(sw);
        Invoke("CloseCamera", time);
    }

    


}