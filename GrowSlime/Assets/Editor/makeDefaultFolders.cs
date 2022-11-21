using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;

public class NewBehaviourScript : MonoBehaviour
{
    [MenuItem("PreWork/Generate Assets Basic Structure")]
    static public void GenerateFolders()
    {
        string projectPath = Application.dataPath + "/";
        Directory.CreateDirectory(projectPath + "01.Scene");
        Directory.CreateDirectory(projectPath + "02.Scripts");
        Directory.CreateDirectory(projectPath + "03.Prefabs");
        Directory.CreateDirectory(projectPath + "04.Images");
        Directory.CreateDirectory(projectPath + "04.Images/inGame");
        Directory.CreateDirectory(projectPath + "04.Images/UI");
        Directory.CreateDirectory(projectPath + "05.Models");
        Directory.CreateDirectory(projectPath + "06.Sounds");
        Directory.CreateDirectory(projectPath + "07.Animations");
        Directory.CreateDirectory(projectPath + "08.Fonts");

        AssetDatabase.Refresh();
    }
    // Start is called before the first frame update
    void Start()
    {
        GenerateFolders();
    }
}
