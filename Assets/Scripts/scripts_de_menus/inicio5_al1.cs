using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using Rewired;

// Token: 0x02000009 RID: 9
public class inicio5_al1 : MonoBehaviour
{
	public string idioma;
	public int plataforma;
	// Token: 0x0600001A RID: 26 RVA: 0x00002523 File Offset: 0x00000723
	private void Start()
	{
		manager_al1 manager = UnityEngine.Object.FindObjectOfType<manager_al1>();
        plataforma = manager.datosserial.plat;
		idioma = manager.datosserial.idioma;
	}

	// Token: 0x0600001B RID: 27 RVA: 0x00002528 File Offset: 0x00000728
	private void Update()
	{
		if(idioma == "")
		{
			SceneManager.LoadScene("idioma");
		}
		else if(plataforma == 0)
		{
			SceneManager.LoadScene("controles");
		}
		else
		{
			SceneManager.LoadScene("presentacion");
		}
	}
}
