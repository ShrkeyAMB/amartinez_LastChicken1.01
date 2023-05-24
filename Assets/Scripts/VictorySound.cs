using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VictorySound : MonoBehaviour
{

    public AudioSource src;
    public AudioClip victory;
    public float currentTime = 0;
    public float totalTime = 8;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += 1 * Time.deltaTime;
        if (currentTime < totalTime)
        {
            src.clip = victory;
            src.Play();
        }
    }
}
