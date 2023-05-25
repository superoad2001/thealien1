using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using Rewired;
using System.Collections;
using System.Collections.Generic;

// Token: 0x02000008 RID: 8
public class inicio : MonoBehaviour
{
	// Token: 0x06000017 RID: 23 RVA: 0x000024DB File Offset: 0x000006DB

	public bool botonm = false;
	public bool botonn = false;
	public bool botonc = false;
	public int gemas = 0;
	public float temp;
	public AudioSource audio;

	public void Start()
	{
		this.gemas = PlayerPrefs.GetInt("gemas", 0);
	}


	// Token: 0x06000018 RID: 24 RVA: 0x000024DD File Offset: 0x000006DD

	private void Update()
	{

		if(!audio.isPlaying)
		{
			SceneManager.LoadScene("intro");
		}
		if (temp < 15)
		{temp += 1 * Time.deltaTime;}

		if (this.botonm == true && temp >= 1)
		{
			if (gemas >= 1)
			{
				SceneManager.LoadScene("piso1_c");
			}
			else
			{
				SceneManager.LoadScene("lallegada");
			}	
		}
		if (this.botonn == true && temp >= 1)
		{
			SceneManager.LoadScene("borrar_partida");
		}
		if (this.botonc == true && temp >= 1)
		{
			SceneManager.LoadScene("opciones");
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

    public void Detenern()
    {
        botonn = false;
    }
	public void Detenerm()
    {
        botonm = false;
    }

}
