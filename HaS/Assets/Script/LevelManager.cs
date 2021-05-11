using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    [SerializeField] Button[] buttonLvl;
    LevelExit levelExit = new LevelExit();

    public void onClik(int index)
    {
        switch(index)
        {
            case 1:
                SceneManager.LoadScene(levelExit.currentLvl);
                break;
            case 2:
                SceneManager.LoadScene(levelExit.currentLvl+1);
                break;
        }

        
    }
}
