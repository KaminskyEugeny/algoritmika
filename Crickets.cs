using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crickets : MonoBehaviour
{
    void Print(string text = "crickets")
    {
        Debug.Log(text);  // Выводим в консоль текст "crickets"
    }
    
    void Start()
    {
        
    }

    
    void Update()
    {
        Print();   
    }
}
