﻿using System;
using UnityEngine;

// Token: 0x02000053 RID: 83
public class moneda49 : MonoBehaviour
{
	public AudioSource audio1;
	// Token: 0x06000142 RID: 322 RVA: 0x00005F47 File Offset: 0x00004147
	private void Start()
	{
	}

	// Token: 0x06000143 RID: 323 RVA: 0x00005F4C File Offset: 0x0000414C
	private void Update()
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		base.transform.Rotate(Vector3.left, 200f * Time.deltaTime);
		if (manager.moneda49 == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x06000144 RID: 324 RVA: 0x00005F8C File Offset: 0x0000418C
	private void OnTriggerEnter(Collider col)
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		manager.moneda49 = 1;
		manager.monedas++;
		PlayerPrefs.SetInt("monedas", manager.monedas);
		PlayerPrefs.SetInt("moneda49", manager.moneda49);
		audio1.Play();
		UnityEngine.Object.Destroy(base.gameObject);
	}
}
