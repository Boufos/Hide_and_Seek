using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelExit : MonoBehaviour
{
    public GameObject ExitAnimation;

    private void OnTriggerEnter(Collider other)
    {
        ExitAnimation.SetActive(true);
        StartCoroutine(LoadScene());
      

    }

    IEnumerator LoadScene()
    {
        yield return new WaitForSeconds(1.3f);
         SaveData.currentLvl = SceneManager.GetActiveScene().buildIndex;
         SceneManager.LoadScene("MenuNextLvl");
    }
}
