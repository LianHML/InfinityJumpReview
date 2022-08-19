using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{    
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        for (int i = 0; i < FindObjectsOfType<DontDestroy>().Length; i++)
        {
            if (FindObjectsOfType<DontDestroy>()[0] != this)
            {
                if (FindObjectsOfType<DontDestroy>()[0].name == gameObject.name)
                {
                    Destroy(gameObject);
                }
            }
        }
    }
}
