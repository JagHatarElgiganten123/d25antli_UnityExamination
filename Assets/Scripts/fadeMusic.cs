using System;
using UnityEngine;

public class fadeMusic : MonoBehaviour
{
    public AudioSource source;
    
    // Update is called once per frame

    private void Awake()
    {
        source.volume = 1;
    }

    void FixedUpdate()
    {
        source.volume -= 0.01f;
    }
}
