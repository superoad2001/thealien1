﻿using System;
using UnityEngine;

// Token: 0x02000075 RID: 117
public class gemanv10 : MonoBehaviour
{
	private int gemaN10 = 0;
	// Token: 0x060001CA RID: 458 RVA: 0x00006CCD File Offset: 0x00004ECD
	private void Start()
	{
		this.gemaN10 = PlayerPrefs.GetInt("gemaN10", 0);
	}

	// Token: 0x060001CB RID: 459 RVA: 0x00006CD0 File Offset: 0x00004ED0
	private void Update()
	{
		
		if (gemaN10 == 1)
		{
			base.transform.position = new Vector3(-6.53999996f,526.799988f,451.910004f);
		}
	}

}
