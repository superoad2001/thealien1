﻿using System;
using UnityEngine;

// Token: 0x02000059 RID: 89
public class moneda9 : MonoBehaviour
{
	public AudioSource audio1;
	// Token: 0x0600015A RID: 346 RVA: 0x00006307 File Offset: 0x00004507
	private void Start()
	{
	}

	// Token: 0x0600015B RID: 347 RVA: 0x0000630C File Offset: 0x0000450C
	private void Update()
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		base.transform.Rotate(Vector3.left, 200f * Time.deltaTime);

		if (manager.moneda9 == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x0600015C RID: 348 RVA: 0x0000634C File Offset: 0x0000454C
	private void OnTriggerEnter(Collider col)
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		manager.moneda9 = 1;
		manager.monedas++;
		PlayerPrefs.SetInt("monedas", manager.monedas);
		PlayerPrefs.SetInt("moneda9", manager.moneda9);
		audio1.Play();
		UnityEngine.Object.Destroy(base.gameObject);
	}
}
