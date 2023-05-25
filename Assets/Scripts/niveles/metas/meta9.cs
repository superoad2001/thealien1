using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using Rewired;

// Token: 0x02000027 RID: 39
public class meta9 : MonoBehaviour
{
	// Token: 0x06000092 RID: 146 RVA: 0x000043D1 File Offset: 0x000025D1
	private void Start()
	{
	}

	// Token: 0x06000093 RID: 147 RVA: 0x000043D3 File Offset: 0x000025D3
	private void Update()
	{
	}

	// Token: 0x06000094 RID: 148 RVA: 0x000043D8 File Offset: 0x000025D8
	private void OnCollisionEnter(Collision col)
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		if (col.gameObject.tag == "Player")
		{
			if (manager.gemaN9 == 0)
			{
				manager.gemas++;
				manager.gemaN9 = 1;
				PlayerPrefs.SetInt("gemas", manager.gemas);
				PlayerPrefs.SetInt("gemaN9", manager.gemaN9);
			}
			SceneManager.LoadScene("piso3");
		}
		if (col.gameObject.tag == "coche2")
		{
			SceneManager.LoadScene("piso3");
		}
	}
}
