﻿using System;
using UnityEngine;

// Token: 0x02000032 RID: 50
public class moneda19 : MonoBehaviour
{
	public AudioSource audio1;

	// Token: 0x060000BE RID: 190 RVA: 0x00004AA7 File Offset: 0x00002CA7
	private void Start()
	{
	}

	// Token: 0x060000BF RID: 191 RVA: 0x00004AAC File Offset: 0x00002CAC
	private void Update()
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		base.transform.Rotate(Vector3.left, 200f * Time.deltaTime);
		if (manager.moneda19 == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x060000C0 RID: 192 RVA: 0x00004AEC File Offset: 0x00002CEC
	private void OnTriggerEnter(Collider col)
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		manager.moneda19 = 1;
		manager.monedas++;
		PlayerPrefs.SetInt("monedas", manager.monedas);
		PlayerPrefs.SetInt("moneda19", manager.moneda19);
		audio1.Play();
		UnityEngine.Object.Destroy(base.gameObject);
	}
}
