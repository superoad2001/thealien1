using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plat : MonoBehaviour
{
    public int plataforma;
    // Start is called before the first frame update
    void Start()
    {
        manager manager = UnityEngine.Object.FindObjectOfType<manager>();
        PlayerPrefs.SetInt("plataforma", plataforma);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
