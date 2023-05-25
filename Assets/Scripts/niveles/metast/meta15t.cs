﻿using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using Rewired;

// Token: 0x0200001F RID: 31
public class meta15t : MonoBehaviour
{
	// Token: 0x06000072 RID: 114 RVA: 0x00003FDC File Offset: 0x000021DC
	private void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "Player")
		{
			manager2 manager2 = UnityEngine.Object.FindObjectOfType<manager2>();
			if (col.gameObject.tag == "Player")
			{
				if (manager2.recordnv15 > manager2.contador)
				{
					manager2.recordnv15 = manager2.contador;
					PlayerPrefs.SetFloat("recordnv15", manager2.recordnv15);
				}
				
				SceneManager.LoadScene("piso4t");
			}
		}
	}

	// Token: 0x06000073 RID: 115 RVA: 0x00004064 File Offset: 0x00002264
	private void Start()
	{
	}

	// Token: 0x06000074 RID: 116 RVA: 0x00004066 File Offset: 0x00002266
	private void Update()
	{
		base.transform.Translate(Vector3.forward * Time.deltaTime / 1.1f * this.velocidad);
	}

	// Token: 0x04000076 RID: 118
	public GameObject jugador;

	// Token: 0x04000077 RID: 119
	public float velocidad = 0.005f;

	// Token: 0x04000078 RID: 120
	private Rigidbody rb;
}
