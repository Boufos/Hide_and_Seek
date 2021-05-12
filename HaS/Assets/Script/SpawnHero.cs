using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnHero : MonoBehaviour
{

    [SerializeField] GameObject spawnObject;
    [SerializeField] ParticleSystem particle;
    void Start()
    {
        StartCoroutine(WaitStart());
    }

    private void Update()
    {
        particle.transform.position= spawnObject.transform.position;
    }

    IEnumerator WaitStart()
    {
        yield return new WaitForSeconds(1f);
        spawnObject.SetActive(true);
    }

    
}
