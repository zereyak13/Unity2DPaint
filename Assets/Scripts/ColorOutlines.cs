using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorOutlines : MonoBehaviour
{
    public static ColorOutlines Instance;
    private void Awake()
    {
        Instance = this;
    }

    public Outline[] outline;
    public Sprite[] brushes;
}
