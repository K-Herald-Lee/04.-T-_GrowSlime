using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{

    public RuntimeAnimatorController[] levelAC;
    public int[] jellyPriceList;
    public void ChangeAC(Animator ani, int level)
    {
        ani.runtimeAnimatorController = levelAC[level-1];
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
