using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lallegadavoz_al1 : MonoBehaviour
{
    public AudioSource audio;
    public AudioSource audioesp;
    public AudioSource audioen;
    public AudioSource audiocat;
    // Start is called before the first frame update
    void Start()
    {
        manager_al1 manager = UnityEngine.Object.FindObjectOfType<manager_al1>();
        if(manager.datosserial.idioma == "es")
        {
            audio = audioesp;
        }
        if(manager.datosserial.idioma == "en")
        {
            audio = audioen;
        }
        if(manager.datosserial.idioma == "cat")
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
