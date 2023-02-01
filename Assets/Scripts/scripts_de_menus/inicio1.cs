using System;
using UnityEngine;
using UnityEngine.SceneManagement;

// Token: 0x02000009 RID: 9
public class inicio1 : MonoBehaviour
{
	public bool botonm = false;
	public bool botonn = false;
	// Token: 0x0600001A RID: 26 RVA: 0x00002523 File Offset: 0x00000723
	private void Start()
	{
	}

	// Token: 0x0600001B RID: 27 RVA: 0x00002528 File Offset: 0x00000728
	private void Update()
	{
		if (Input.GetAxis("m") < 0f || this.botonm == true)
		{
			SceneManager.LoadScene("menu_de_carga");
		}
		if (Input.GetAxis("n") < 0f || this.botonn == true)
		{
			PlayerPrefs.DeleteAll();
			SceneManager.LoadScene("lallegada");
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
