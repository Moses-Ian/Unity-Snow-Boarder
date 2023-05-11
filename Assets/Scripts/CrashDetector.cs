using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float ReloadDelay = .5f;
    [SerializeField] ParticleSystem HitEffect;
    [SerializeField] AudioClip CrashSFX;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Ground")
        {
            HitEffect.Play();
            GetComponent<AudioSource>().PlayOneShot(CrashSFX);
            Invoke("ReloadScene", ReloadDelay);
        }
    }
    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
