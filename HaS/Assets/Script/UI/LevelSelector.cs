using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour
{
    public Button[] levels;

    void Start()
    {
        int levelReached = PlayerPrefs.GetInt("levelReached", 1);    
        for(int i=0; i<levels.Length;i++)
        {
            if(i+1>levelReached)
            {
                levels[i].interactable = false;
            }
        }
    }

    public void Select(int idScene)
    {
        SceneManager.LoadScene(idScene);
    }
}