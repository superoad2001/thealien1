﻿using System;
using UnityEngine;

// Token: 0x02000075 RID: 117
public class gemanv12 : MonoBehaviour
{
	private int gemaN12 = 0;
	// Token: 0x060001CA RID: 458 RVA: 0x00006CCD File Offset: 0x00004ECD
	private void Start()
	{
		this.gemaN12 = PlayerPrefs.GetInt("gemaN12", 0);
	}

	// Token: 0x060001CB RID: 459 RVA: 0x00006CD0 File Offset: 0x00004ED0
	private void Update()
	{
		
		if (gemaN12 == 1)
		{
			base.transform.position = new Vector3(6.28999996f,526.799988f,447.980011f);
		}
	}

}
