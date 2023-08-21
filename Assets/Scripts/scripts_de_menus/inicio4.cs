using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using Rewired;

// Token: 0x02000009 RID: 9
public class inicio4 : MonoBehaviour
{
	public bool botonm = false;
	public bool botonn = false;
	public float temp;
	public int plataforma;
	// Token: 0x0600001A RID: 26 RVA: 0x00002523 File Offset: 0x00000723
	private void Start()
	{
		plataforma = PlayerPrefs.GetInt("plataforma", 0);
	}

	// Token: 0x0600001B RID: 27 RVA: 0x00002528 File Offset: 0x00000728
	private void Update()
	{
		if (temp < 15)
		{temp += 1 * Time.deltaTime;}
		if (this.botonm == true && temp >= 1)
		{
			PlayerPrefs.SetInt("plataforma", 1);
			SceneManager.LoadScene("menu_de_carga");
		}
		if (this.botonn == true && temp >= 1)
		{
			PlayerPrefs.SetInt("plataforma", 2);
			SceneManager.LoadScene("menu_de_carga");
		}
		if(plataforma != 0)
		{
			SceneManager.LoadScene("presentacion");
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
