﻿using System;
using UnityEngine;

// Token: 0x0200003D RID: 61
public class moneda29 : MonoBehaviour
{
	public AudioSource audio1;
	// Token: 0x060000EA RID: 234 RVA: 0x00005187 File Offset: 0x00003387
	private void Start()
	{
	}

	// Token: 0x060000EB RID: 235 RVA: 0x0000518C File Offset: 0x0000338C
	private void Update()
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		base.transform.Rotate(Vector3.left, 200f * Time.deltaTime);
		if (manager.moneda29 == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x060000EC RID: 236 RVA: 0x000051CC File Offset: 0x000033CC
	private void OnTriggerEnter(Collider col)
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		manager.moneda29 = 1;
		manager.monedas++;
		PlayerPrefs.SetInt("monedas", manager.monedas);
		PlayerPrefs.SetInt("moneda29", manager.moneda29);
		audio1.Play();
		UnityEngine.Object.Destroy(base.gameObject);
	}
}
