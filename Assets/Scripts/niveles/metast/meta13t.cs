﻿using System;
using UnityEngine;
using UnityEngine.SceneManagement;

// Token: 0x02000019 RID: 25
public class meta13t : MonoBehaviour
{
	// Token: 0x0600005A RID: 90 RVA: 0x00003C7D File Offset: 0x00001E7D
	private void Start()
	{
	}

	// Token: 0x0600005B RID: 91 RVA: 0x00003C7F File Offset: 0x00001E7F
	private void Update()
	{
	}

	// Token: 0x0600005C RID: 92 RVA: 0x00003C84 File Offset: 0x00001E84
	private void OnCollisionEnter(Collision col)
	{
		manager2 manager2 = UnityEngine.Object.FindObjectOfType<manager2>();
		if (col.gameObject.tag == "Player")
		{
			if (manager2.recordnv13 > manager2.contador)
			{
				manager2.recordnv13 = manager2.contador;
				PlayerPrefs.SetFloat("recordnv13", manager2.recordnv13);
			}
			
			SceneManager.LoadScene("piso2t");
		}
	}
}
