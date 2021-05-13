using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    [SerializeField] GameObject[] button;

    public void onClik()
    {
        button[0].SetActive(false);
        button[1].SetActive(true);
    }
}
