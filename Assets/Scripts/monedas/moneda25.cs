﻿using System;
using UnityEngine;

// Token: 0x02000039 RID: 57
public class moneda25 : MonoBehaviour
{
	public AudioSource audio1;
	// Token: 0x060000DA RID: 218 RVA: 0x00004F07 File Offset: 0x00003107
	private void Start()
	{
	}

	// Token: 0x060000DB RID: 219 RVA: 0x00004F0C File Offset: 0x0000310C
	private void Update()
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		base.transform.Rotate(Vector3.left, 200f * Time.deltaTime);
		if (manager.moneda25 == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x060000DC RID: 220 RVA: 0x00004F4C File Offset: 0x0000314C
	private void OnTriggerEnter(Collider col)
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		manager.moneda25 = 1;
		manager.monedas++;
		PlayerPrefs.SetInt("monedas", manager.monedas);
		PlayerPrefs.SetInt("moneda25", manager.moneda25);
		audio1.Play();
		UnityEngine.Object.Destroy(base.gameObject);
	}
}
