﻿using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using Rewired;

// Token: 0x02000071 RID: 113
public class puerta15t : MonoBehaviour
{
	// Token: 0x060001BA RID: 442 RVA: 0x00006B5C File Offset: 0x00004D5C
	private void Start()
	{
	}

	// Token: 0x060001BB RID: 443 RVA: 0x00006B5E File Offset: 0x00004D5E
	private void Update()
	{
	}

	// Token: 0x060001BC RID: 444 RVA: 0x00006B60 File Offset: 0x00004D60
	private void OnCollisionEnter(Collision col)
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		if (col.gameObject.tag == "Player")
		{
			SceneManager.LoadScene("nivel12t");
		}
	}
}
