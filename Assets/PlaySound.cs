using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    public AudioSource audioSource;
    public float delay = 5;

    void Start()
    {
        audioSource.PlayDelayed(delay);
    }
   

    // Update is called once per frame
    void Update()
    {
   
    }
}
