using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnHero : MonoBehaviour
{

    [SerializeField] GameObject spawnObject;
    void Start()
    {
        StartCoroutine(WaitStart());
    }

    IEnumerator WaitStart()
    {
        yield return new WaitForSeconds(1f);
        spawnObject.SetActive(true);
    }

    
}
