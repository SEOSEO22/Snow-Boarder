using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float delayTime = 0.5f;
    [SerializeField] ParticleSystem particle;
    [SerializeField] AudioSource audio;

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Ground") {
            particle.Play();
            audio.Play();
            Invoke("ReloadScene", delayTime);
        }
    }

    void ReloadScene() {
        SceneManager.LoadScene(0);
    }
}
