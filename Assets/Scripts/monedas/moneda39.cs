﻿using System;
using UnityEngine;

// Token: 0x02000048 RID: 72
public class moneda39 : MonoBehaviour
{
	public AudioSource audio1;
	// Token: 0x06000116 RID: 278 RVA: 0x00005867 File Offset: 0x00003A67
	private void Start()
	{
	}

	// Token: 0x06000117 RID: 279 RVA: 0x0000586C File Offset: 0x00003A6C
	private void Update()
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		base.transform.Rotate(Vector3.left, 200f * Time.deltaTime);
		if (manager.moneda39 == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x06000118 RID: 280 RVA: 0x000058AC File Offset: 0x00003AAC
	private void OnTriggerEnter(Collider col)
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		manager.moneda39 = 1;
		manager.monedas++;
		PlayerPrefs.SetInt("monedas", manager.monedas);
		PlayerPrefs.SetInt("moneda39", manager.moneda39);
		audio1.Play();
		UnityEngine.Object.Destroy(base.gameObject);
	}
}
