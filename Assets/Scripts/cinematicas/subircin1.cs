﻿using System;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

// Token: 0x02000010 RID: 16
public class subircin1 : MonoBehaviour
{
	public bool botonm = false;
	public GameObject tactil;
	// Token: 0x06000038 RID: 56 RVA: 0x00003A94 File Offset: 0x00001C94
	private void Start()
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		if(manager.plataforma == 1)
		{
			tactil.SetActive(false);
		}
		if(manager.plataforma == 2)
		{
			tactil.SetActive(true);
		}
	}

	// Token: 0x06000039 RID: 57 RVA: 0x00003A96 File Offset: 0x00001C96
	private void Update()
	{
		if (Input.GetAxis("m") < 0f || botonm == true)
		{
			SceneManager.LoadScene("piso1_c");
		}
	}
	public void boton_m()
    {
        botonm = true;
    }
	public void Detenerm()
    {
        botonm = false;
    }
}
