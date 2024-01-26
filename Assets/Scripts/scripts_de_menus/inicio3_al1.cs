﻿using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using Rewired;

// Token: 0x02000009 RID: 9
public class inicio3_al1 : MonoBehaviour
{
	public bool botonm = false;
	public bool botonn = false;
	public bool botonc = false;
	public float temp;
	public string idioma;
	// Token: 0x0600001A RID: 26 RVA: 0x00002523 File Offset: 0x00000723
	private void Start()
	{
		manager_al1 manager = UnityEngine.Object.FindObjectOfType<manager_al1>();
        idioma = manager.datosserial.idioma;
	}

	// Token: 0x0600001B RID: 27 RVA: 0x00002528 File Offset: 0x00000728
	private void Update()
	{
		manager_al1 manager = UnityEngine.Object.FindObjectOfType<manager_al1>();
		if (temp < 15)
		{temp += 1 * Time.deltaTime;}
		if (this.botonm == true && temp >= 1)
		{
			manager.datosserial.idioma = "es";
			manager.guardar();
			SceneManager.LoadScene("controles");
		}
		if (this.botonn == true && temp >= 1)
		{
			manager.datosserial.idioma = "en";
			manager.guardar();
			SceneManager.LoadScene("controles");
		}
		if (this.botonc == true && temp >= 1)
		{
			manager.datosserial.idioma = "cat";
			manager.guardar();
			SceneManager.LoadScene("controles");
		}
		if(idioma != "no")
		{
			SceneManager.LoadScene("controles");
		}
	}
	public void boton_m()
    {
        botonm = true;
    }
	public void boton_n()
    {
        botonn = true;
    }
	public void boton_c()
    {
        botonc = true;
    }

}
