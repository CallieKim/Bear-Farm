using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class menuGallery : MonoBehaviour {
    private bool gazedAt;
    AudioSource source;
    static public bool galleryOn;
    public GameObject pauseMenuPanel;
    public GameObject camera;
    public GameObject galleryM;

    // Use this for initialization
    void Start () {
        source = gameObject.GetComponent<AudioSource>();
        galleryOn = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (gazedAt)
        {
            if (Input.GetButtonUp("Fire1"))
            {
                source.Play();
                galleryOn = true;
                Debug.Log("galleryOn is " + galleryOn);
                galleryM.GetComponent<GalleryManager>().showGallery();
                pauseMenuPanel.SetActive(false);
            }
        }
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
