using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using Rewired;

// Token: 0x02000009 RID: 9
public class inicio2 : MonoBehaviour
{
	public bool botonm = false;
	public bool botonn = false;
	public bool botonc = false;
	public bool botont = false;
	public bool botonr = false;
	public float temp;
	// Token: 0x0600001A RID: 26 RVA: 0x00002523 File Offset: 0x00000723
	private void Start()
	{
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


		if (this.botonc == true && temp >= 1)
		{
			PlayerPrefs.SetString("idioma", "es");
			SceneManager.LoadScene("menu_de_carga");
		}
		if (this.botont == true && temp >= 1)
		{
			PlayerPrefs.SetString("idioma", "en");
			SceneManager.LoadScene("menu_de_carga");
		}
		if (this.botonr == true && temp >= 1)
		{
			PlayerPrefs.SetString("idioma", "cat");
			SceneManager.LoadScene("menu_de_carga");
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
	public void boton_t()
    {
        botont = true;
    }
	public void boton_r()
    {
        botonr = true;
    }


}
