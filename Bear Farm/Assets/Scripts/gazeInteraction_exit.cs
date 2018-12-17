using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class gazeInteraction_exit : MonoBehaviour {
    private bool gazedAt;
    AudioSource source;

    // Use this for initialization
    void Start()
    {
        source = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gazedAt)
        {
            if (Input.GetButtonUp("Fire1"))
            {
                source.Play();
                Application.Quit();
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
