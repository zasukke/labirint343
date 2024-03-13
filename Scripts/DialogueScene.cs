using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueScene : MonoBehaviour
{
    public string[] ArrayDialog;
    public int counter = 0;
    public Text text;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void Back()
    {
        counter -= 1;
        text.text = ArrayDialog[counter];
    }

    public void Next()
    {
        counter += 1;
        text.text = ArrayDialog[counter];
    }
}
