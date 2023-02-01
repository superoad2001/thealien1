using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ascensor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        jugador jugador = UnityEngine.Object.FindObjectOfType<jugador>();
        if(jugador.subir == true)
        {
            base.transform.Translate(Vector3.up * 4f * Time.deltaTime);
        }
        if(jugador.bajar == true)
        {
            base.transform.Translate(Vector3.up * -4f * Time.deltaTime);
        }
    }
}
