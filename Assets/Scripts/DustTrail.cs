using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustTrail : MonoBehaviour
{
    [SerializeField] ParticleSystem particle;

    private void OnCollisionExit2D(Collision2D other) {
        if (other.gameObject.tag == "Ground") {
            // particle.gameObject.SetActive(false);
            particle.Stop();
        }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.tag == "Ground") {
            particle.Play();
        }
    }
}
