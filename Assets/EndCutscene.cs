using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndCutscene : MonoBehaviour
{
    public ThirdPersonController controller;
    public Animator animator;
    public GameObject levelChange;
    public GameObject fadeOut;
    public float transitionLength = 2f;


    void OnTriggerEnter(Collider other)
    {
        //other.name should equal the root of your Player object
        if (other.tag == "Player")
        {
            FreezePlayer();
            fadeOut.SetActive(true);
            StartCoroutine(CutsceneStart());
        }
    }

    void FreezePlayer()
    {
        controller.enabled = false;
        animator.enabled = false;
    }

    public IEnumerator CutsceneStart()
    {
        yield return new WaitForSeconds(transitionLength);
        levelChange.SetActive(true);

        yield return null;
    }
}
