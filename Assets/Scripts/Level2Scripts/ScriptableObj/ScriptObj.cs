using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

public class ScriptObj : ScriptableObject
{
    private static ScriptObj _instance;
    public static ScriptObj Instance { get { return _instance; } }

    private float healthPoint;

    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this);
        }
        else
        {
            _instance = this;
        }
    }
}
