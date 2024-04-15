using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class soundValues : MonoBehaviour
{

    public AudioMixer audioMixer;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    public void sesDegeri(float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }
}
