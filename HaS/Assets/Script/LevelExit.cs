using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelExit : MonoBehaviour
{
   
    
    private void OnTriggerEnter(Collider other)
    {
        SaveData.currentLvl = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene("MenuNextLvl");

    }
}
