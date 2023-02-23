using System;
using UnityEngine;
using UnityEngine.SceneManagement;

// Token: 0x02000008 RID: 8
public class espacio_c : MonoBehaviour
{
	public bool botonm = false;
	public GameObject tactil;
	// Token: 0x06000017 RID: 23 RVA: 0x000024DB File Offset: 0x000006DB
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

	// Token: 0x06000018 RID: 24 RVA: 0x000024DD File Offset: 0x000006DD
	private void Update()
	{
		if (Input.GetAxis("Jump") > 0f || botonm == true)
		{
			SceneManager.LoadScene("espacio");
		}
	}
	public void boton_m()
    {
        botonm = true;
    }
	public void detenerm()
    {
        botonm = false;
    }
}
