﻿using System;
using UnityEngine;

// Token: 0x0200004F RID: 79
public class moneda45 : MonoBehaviour
{
	public AudioSource audio1;
	// Token: 0x06000132 RID: 306 RVA: 0x00005CC7 File Offset: 0x00003EC7
	private void Start()
	{
	}

	// Token: 0x06000133 RID: 307 RVA: 0x00005CCC File Offset: 0x00003ECC
	private void Update()
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		base.transform.Rotate(Vector3.left, 200f * Time.deltaTime);
		if (manager.moneda45 == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x06000134 RID: 308 RVA: 0x00005D0C File Offset: 0x00003F0C
	private void OnTriggerEnter(Collider col)
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		manager.moneda45 = 1;
		manager.monedas++;
		PlayerPrefs.SetInt("monedas", manager.monedas);
		PlayerPrefs.SetInt("moneda45", manager.moneda45);
		audio1.Play();
		UnityEngine.Object.Destroy(base.gameObject);
	}
}
