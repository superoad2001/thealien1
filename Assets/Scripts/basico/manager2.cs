using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using Rewired;
using UnityEngine.UI;

public class manager2 : MonoBehaviour
{
    
    public float contador = 0;
    public Text crono;
    public Text nv1;
    public Text nv2;
    public Text nv3;
    public Text nv4;
    public Text nv5;
    public Text nv6;
    public Text nv7;
    public Text nv8;
    public Text nv9;
    public Text nv10;
    public Text nv11;
    public Text nv12;
    public Text nv13;
    public Text nv14;
    public Text nv15;
    public float recordnv1;
    public float recordnv2;
    public float recordnv3;
    public float recordnv4;
    public float recordnv5;
    public float recordnv6;
    public float recordnv7;
    public float recordnv8;
    public float recordnv9;
    public float recordnv10;
    public float recordnv11;
    public float recordnv12;
    public float recordnv13;
    public float recordnv14;
    public float recordnv15;
    // Start is called before the first frame update
    void Start()
    {
        recordnv1 = PlayerPrefs.GetFloat("recordnv1", 888);
        recordnv2 = PlayerPrefs.GetFloat("recordnv2", 888);
        recordnv3 = PlayerPrefs.GetFloat("recordnv3", 888);
        recordnv4 = PlayerPrefs.GetFloat("recordnv4", 888);
        recordnv5 = PlayerPrefs.GetFloat("recordnv5", 888);
        recordnv6 = PlayerPrefs.GetFloat("recordnv6", 888);
        recordnv7 = PlayerPrefs.GetFloat("recordnv7", 888);
        recordnv8 = PlayerPrefs.GetFloat("recordnv8", 888);
        recordnv9 = PlayerPrefs.GetFloat("recordnv9", 888);
        recordnv10 = PlayerPrefs.GetFloat("recordnv10", 888);
        recordnv11 = PlayerPrefs.GetFloat("recordnv11", 888);
        recordnv12 = PlayerPrefs.GetFloat("recordnv12", 888);
        recordnv13 = PlayerPrefs.GetFloat("recordnv13", 888);
        recordnv14 = PlayerPrefs.GetFloat("recordnv14", 888);
        recordnv15 = PlayerPrefs.GetFloat("recordnv15", 888);
        manager manager = UnityEngine.Object.FindObjectOfType<manager>();
        if (manager.piso == -5)
        {
            nv1.text = "nivel 1 parque de saltos : " + recordnv1;
            nv2.text = "nivel 2 zona de planeadores : " + recordnv2;
            nv3.text = "nivel 3 aceras de principiante : " + recordnv3;
            nv4.text = "nivel 4 islas de salto de altura : " + recordnv4;
            nv5.text = "nivel 5 aceras de salto : " + recordnv5;
            nv6.text = "nivel 6 mirador en la altura : " + recordnv6;
            nv7.text = "nivel 7 tercer piso sin ascensor : " + recordnv7;
            nv8.text = "nivel 8 carretera para principiantes : " + recordnv8;
            nv9.text = "nivel 9 carretera con obstaculos : " + recordnv9;
            nv10.text = "nivel 10 subida infernal no esta tan mal : " + recordnv10;
            nv11.text = "nivel 11 carrera del siglo : " + recordnv11;
            nv12.text = "nivel 12 alien invaders : " + recordnv12;
            nv13.text = "nivel 13 subida infernal a secas : " + recordnv13;
            nv14.text = "nivel 14 carrera de la muerte : " + recordnv14;
            nv15.text = "nivel 15  pilla pilla nivel dios : " + recordnv15;
            nv1.text = nv1.text.Substring(0, 31);
            nv2.text = nv2.text.Substring(0, 34);
            nv3.text = nv3.text.Substring(0, 37);
            nv4.text = nv4.text.Substring(0, 39);
            nv5.text = nv5.text.Substring(0, 30);

            nv6.text = nv6.text.Substring(0, 35);
            nv7.text = nv7.text.Substring(0, 37);
            nv8.text = nv8.text.Substring(0, 43);
            nv9.text = nv9.text.Substring(0, 39);
            nv10.text = nv10.text.Substring(0, 47);

            nv11.text = nv11.text.Substring(0, 33);
            nv12.text = nv12.text.Substring(0, 30);
            nv13.text = nv13.text.Substring(0, 39);
            nv14.text = nv14.text.Substring(0, 36);
            nv15.text = nv15.text.Substring(0, 39);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        crono.text = crono.text.Substring(0, 12);
        manager manager = UnityEngine.Object.FindObjectOfType<manager>();
        if(manager.juego != -1)
        {
        contador += 1 * Time.deltaTime;
            if(manager.idioma == "es")
            {
            this.crono.text = "crono : " + contador;
            crono.text = crono.text.Substring(0, 12);
            }
            if(manager.idioma == "en")
            {
            this.crono.text = "chrono : " + contador;
            crono.text = crono.text.Substring(0, 13);
            }
            if(manager.idioma == "cat")
            {
            this.crono.text = "crono : " + contador;
            crono.text = crono.text.Substring(0, 12);
            }
        }
    }
}
