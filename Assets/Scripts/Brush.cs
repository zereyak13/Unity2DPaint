using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Brush : MonoBehaviour
{
    public static Brush Instance;

    public Vector3 offset;
    public Camera cam;

    [SerializeField] private RectTransform canvasRectTransform;
    private void Awake()
    {
        Instance = this;
    }
    private void Start()
    {
        Cursor.visible = false;
    }
    private void Update()
    {
        gameObject.GetComponent<RectTransform>().anchoredPosition = Input.mousePosition / canvasRectTransform.localScale.x;
    }
}
