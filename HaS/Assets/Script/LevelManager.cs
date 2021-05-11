using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    [SerializeField] Button[] buttonLvl;

    private void Start()
    {
        SaveData.FinishLvl = SceneManager.sceneCount;
    }
    public void onClik(int index)
    {
        if(SaveData.FinishLvl< SaveData.currentLvl)
        {
            SceneManager.LoadScene("FinalScene");
        }
        switch (index)
        {
            case 1:
                SceneManager.LoadScene(SaveData.currentLvl);
                break;
            case 2:
                SceneManager.LoadScene(SaveData.currentLvl+1);
                break;
        }

        
    }
}
