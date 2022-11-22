using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{

    public RuntimeAnimatorController[] levelAC;
    public void ChangeAC(Animator ani, int level)
    {
        ani.runtimeAnimatorController = levelAC[level-1];
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
