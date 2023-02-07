using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

// Token: 0x02000008 RID: 8
public class inicio : MonoBehaviour
{
	// Token: 0x06000017 RID: 23 RVA: 0x000024DB File Offset: 0x000006DB

	public bool botonm = false;
	public bool botonn = false;
	public int gemas = 0;

	public void Start()
	{
		this.gemas = PlayerPrefs.GetInt("gemas", 0);
	}


	// Token: 0x06000018 RID: 24 RVA: 0x000024DD File Offset: 0x000006DD

	private void Update()
	{

		if (this.botonm == true)
		{
			if (gemas >= 1)
			{
				SceneManager.LoadScene("mundo");
			}
			else
			{
				SceneManager.LoadScene("lallegada");
			}	
		}
		if (this.botonn == true)
		{
			SceneManager.LoadScene("borrar_partida");
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

    public void Detenern()
    {
        botonn = false;
    }
	public void Detenerm()
    {
        botonm = false;
    }

}
