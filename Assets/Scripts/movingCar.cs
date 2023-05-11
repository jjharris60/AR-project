using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingCar : MonoBehaviour
{
    int tapCount = 0;
    bool startAnimation = false;
    public float speed = 5f; // speed of the car
    private AudioSource audioSource; // Reference to the audio source

    void Start()
    {
        audioSource = GetComponent<AudioSource>(); // Returns the 'AudioSource' component attached to the AR prefab
    }

    void Update()
    {
        if (transform.position.z < 2f && startAnimation && tapCount == 2)
        {
            transform.position += new Vector3(0, 0, 0.05f);
        }
    }

    public void OnTap()
    {
        tapCount++;

        if (tapCount == 2)
        {
            startAnimation = true;
            audioSource.Play();
        }
    }
}
