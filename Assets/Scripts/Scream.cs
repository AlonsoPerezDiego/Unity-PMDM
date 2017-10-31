using UnityEngine;
using System.Collections;

public class Scream : MonoBehaviour {

    public AudioSource songSource = null;
    public float volume = 1.0f;
    public AudioClip song;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("ScreamZone"))
        {
            songSource.clip = song;
            songSource.volume = volume;
            songSource.Play();
        }
    }
}
