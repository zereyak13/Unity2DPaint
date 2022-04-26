using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public Sprite[] PagesToPaint;

    [SerializeField] private GameObject palette;


    private AudioSource audioSource;
    private bool isAudioSourceActive;
    // Start is called before the first frame update

    private void Awake()
    {
        SetPalettesSprite();
    }
    void Start()
    {
        audioSource = GameObject.Find("SoundManager").GetComponent<AudioSource>();
        isAudioSourceActive = true;    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SoundButton()
    {
        isAudioSourceActive = !isAudioSourceActive;
        audioSource.enabled = isAudioSourceActive;
    }
    public void MainScene()
    {
        Cursor.visible = true;
        SceneManager.LoadScene("MainScene");
    }

    private void SetPalettesSprite()
    {
        palette.GetComponent<SpriteRenderer>().sprite = PagesToPaint[PlayerPrefs.GetInt("SelectedIndex")];
    }
}
