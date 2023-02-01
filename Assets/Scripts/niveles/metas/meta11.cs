using System;
using UnityEngine;
using UnityEngine.SceneManagement;

// Token: 0x0200001B RID: 27
public class meta11 : MonoBehaviour
{
	// Token: 0x06000062 RID: 98 RVA: 0x00003D5A File Offset: 0x00001F5A
	private void Start()
	{
	}

	// Token: 0x06000063 RID: 99 RVA: 0x00003D5C File Offset: 0x00001F5C
	private void Update()
	{
	}

	// Token: 0x06000064 RID: 100 RVA: 0x00003D60 File Offset: 0x00001F60
	private void OnCollisionEnter(Collision col)
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		if (col.gameObject.tag == "Player")
		{
			if (manager.gemaN11 == 0)
			{
				manager.gemas++;
				manager.gemaN11 = 1;
				PlayerPrefs.SetInt("gemas", manager.gemas);
				PlayerPrefs.SetInt("gemaN11", manager.gemaN11);
			}
			SceneManager.LoadScene("piso4");
		}
		if (col.gameObject.tag == "coche2")
		{
			SceneManager.LoadScene("piso4");
		}
	}
}
