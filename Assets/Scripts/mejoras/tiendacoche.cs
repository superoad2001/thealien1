﻿using System;
using UnityEngine;

// Token: 0x02000079 RID: 121
public class tiendacoche : MonoBehaviour
{
	// Token: 0x060001DA RID: 474 RVA: 0x00006FD7 File Offset: 0x000051D7
	private void Start()
	{
	}

	// Token: 0x060001DB RID: 475 RVA: 0x00006FDC File Offset: 0x000051DC
	private void Update()
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		if (manager.tengocoche == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		if (manager.gemas >= 6 && manager.monedas >= 20)
		{
			base.transform.position = new Vector3(-5.56f, 527.46f, 450.05f);
		}
	}

	// Token: 0x060001DC RID: 476 RVA: 0x00007040 File Offset: 0x00005240
	private void OnTriggerEnter(Collider col)
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		if (col.gameObject.tag == "Player")
		{
			manager.tengocoche = 1;
			PlayerPrefs.SetInt("coche", manager.tengocoche);
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}
}
