using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingCar : MonoBehaviour
{
    bool startAnimation = false;
    public float speed = 0.009f; // speed of the car
    private AudioSource audioSource; // Reference to the audio source

    void Start()
    {
        audioSource = GetComponent<AudioSource>(); // Returns the 'AudioSource' component attached to the AR prefab
    }

    void Update()
    {
        if (transform.position.z < 2f && startAnimation)
        {
            transform.position += new Vector3(0, 0, 0.08f);
        }
    }

    public void moveCar()
    {
       startAnimation = true;
       audioSource.Play();
    }
}
