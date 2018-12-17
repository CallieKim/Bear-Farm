using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine;

public class menuOption : MonoBehaviour {
    static public bool pause;
    public static bool optionOn;
    public GameObject pauseMenuPanel;
    //public GameObject titleMenu;
    public GameObject optionMenu;
    public GameObject camera;

    AudioSource source;
    AudioSource enemySound;
    GameObject enemy;
    public GameObject daynight;
    daynightchange daynightchange;

    private bool gazedAt;

    // Use this for initialization
    void Start () {
        gazedAt = false;
        optionOn = false;
        optionMenu.SetActive(false);
        source = gameObject.GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
        if (gazedAt)
        {
            if (Input.GetButtonUp("Fire1"))
            {
                source.Play();
                optionMenu.transform.position = pauseMenuPanel.transform.position;
                optionMenu.transform.rotation = pauseMenuPanel.transform.rotation;
                pauseMenuPanel.SetActive(false);
                optionMenu.SetActive(true);
                optionOn = true;
            }
        }
        //else if (Input.GetButtonUp("Jump"))//스페이스를 메뉴상태에서 누르면 한번씩 뒤로 간다
        //{
        //    source.Play();
        //    optionMenu.SetActive(false);
        //    pauseMenuPanel.SetActive(true);
        //    optionOn = false;
        //}
        
    }

    public void onPointerEnter()
    {
        gazedAt = true;
    }

    public void onPointerExit()
    {
        gazedAt = false;
    }
}
