using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
public class SpriteIndex : MonoBehaviour
{
    public int index;
    public void SelectedSprite()
    {
        int selectedIndex = EventSystem.current.currentSelectedGameObject.gameObject.GetComponent<SpriteIndex>().index;
        PlayerPrefs.SetInt("SelectedIndex", selectedIndex);
        SceneManager.LoadScene("DrawingScene");
    }
}
