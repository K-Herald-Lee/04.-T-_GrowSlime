using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{

    public RuntimeAnimatorController[] levelAC;
    public int[] jellyPriceList;
    public Sprite[] jellySpriteList;
    public string[] jellyNameList;
    public int[] jellyJelatinList;
    public int[] capPriceList;
    public int[] prodPriceList;

    public void ChangeAC(Animator ani, int level)
    {
        ani.runtimeAnimatorController = levelAC[level-1];
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
