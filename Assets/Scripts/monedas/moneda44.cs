﻿using System;
using UnityEngine;

// Token: 0x0200004E RID: 78
public class moneda44 : MonoBehaviour
{
	public AudioSource audio1;
	// Token: 0x0600012E RID: 302 RVA: 0x00005C27 File Offset: 0x00003E27
	private void Start()
	{
	}

	// Token: 0x0600012F RID: 303 RVA: 0x00005C2C File Offset: 0x00003E2C
	private void Update()
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		base.transform.Rotate(Vector3.left, 200f * Time.deltaTime);
		if (manager.moneda44 == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x06000130 RID: 304 RVA: 0x00005C6C File Offset: 0x00003E6C
	private void OnTriggerEnter(Collider col)
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		manager.moneda44 = 1;
		manager.monedas++;
		PlayerPrefs.SetInt("monedas", manager.monedas);
		PlayerPrefs.SetInt("moneda44", manager.moneda44);
		audio1.Play();
		UnityEngine.Object.Destroy(base.gameObject);
	}
}
