using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lallegadavoz : MonoBehaviour
{
    public AudioSource audio;
    public AudioSource audioesp;
    public AudioSource audioen;
    public AudioSource audiocat;
    // Start is called before the first frame update
    void Start()
    {
        manager manager = UnityEngine.Object.FindObjectOfType<manager>();
        if(manager.idioma == "es")
        {
            audio = audioesp;
        }
        if(manager.idioma == "en")
        {
            audio = audioen;
        }
        if(manager.idioma == "cat")
        {
            audio = audiocat;
        }
        audio.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
