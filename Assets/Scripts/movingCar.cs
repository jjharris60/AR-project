using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingCar : MonoBehaviour
{
    bool startAnimation = false;
    public float speed = 5f; // speed of the car
    private AudioSource audioSource; // Reference to the audio source
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>(); // Returns the 'AudioSource' component attatched to the moving car prefab
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z < 5f && startAnimation)
        {
            transform.position += new Vector3(0, 0, 0.05f); 
        }
        
    }
    public void moveCar()
    {
        startAnimation = true;
        audioSource.Play();
    }
}
