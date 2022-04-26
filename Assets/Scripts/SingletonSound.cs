using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonSound : MonoBehaviour
{
    private static SingletonSound singletonSound;

    private void Awake()
    {
        if(singletonSound == null)
        {
            singletonSound = this;
        }
        else
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(singletonSound);
    }
    void Update()
    {
        
    }
}
