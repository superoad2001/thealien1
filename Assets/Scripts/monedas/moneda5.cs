﻿using System;
using UnityEngine;

// Token: 0x02000054 RID: 84
public class moneda5 : MonoBehaviour
{
	public AudioSource audio1;
	// Token: 0x06000146 RID: 326 RVA: 0x00005FE7 File Offset: 0x000041E7
	private void Start()
	{
	}

	// Token: 0x06000147 RID: 327 RVA: 0x00005FEC File Offset: 0x000041EC
	private void Update()
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
				base.transform.Rotate(Vector3.left, 200f * Time.deltaTime);

		if (manager.moneda5 == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x06000148 RID: 328 RVA: 0x0000602C File Offset: 0x0000422C
	private void OnTriggerEnter(Collider col)
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		manager.moneda5 = 1;
		manager.monedas++;
		PlayerPrefs.SetInt("monedas", manager.monedas);
		PlayerPrefs.SetInt("moneda5", manager.moneda5);
		audio1.Play();
		UnityEngine.Object.Destroy(base.gameObject);
	}
}
