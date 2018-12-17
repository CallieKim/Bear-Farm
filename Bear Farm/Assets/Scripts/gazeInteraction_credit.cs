using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class gazeInteraction_credit : MonoBehaviour {
    private bool gazedAt;
    public GameObject titleMenu;
    public GameObject optionMenu;
    public GameObject creditMenu;
    public GameObject tutorialMenu;
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
                titleMenu.SetActive(false);
                creditMenu.SetActive(true);
            }
            //if (Input.GetButtonUp("Jump"))//스페이스를 메뉴상태에서 누르면 한번씩 뒤로 간다
            //{
            //    source.Play();
            //    creditMenu.SetActive(false);
            //    optionMenu.SetActive(false);
            //    tutorialMenu.SetActive(false);
            //    titleMenu.SetActive(true);
            //}
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
