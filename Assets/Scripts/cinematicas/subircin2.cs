using System;
using UnityEngine;
using UnityEngine.SceneManagement;

// Token: 0x02000011 RID: 17
public class subircin2 : MonoBehaviour
{
	public bool botonm = false;
	// Token: 0x06000038 RID: 56 RVA: 0x00003A94 File Offset: 0x00001C94
	private void Start()
	{
	}

	// Token: 0x06000039 RID: 57 RVA: 0x00003A96 File Offset: 0x00001C96
	private void Update()
	{
		if (Input.GetAxis("m") < 0f || botonm == true)
		{
			SceneManager.LoadScene("espacio");
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
