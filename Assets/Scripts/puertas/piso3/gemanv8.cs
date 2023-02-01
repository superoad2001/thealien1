using System;
using UnityEngine;

// Token: 0x02000075 RID: 117
public class gemanv8 : MonoBehaviour
{
	private int gemaN8 = 0;
	// Token: 0x060001CA RID: 458 RVA: 0x00006CCD File Offset: 0x00004ECD
	private void Start()
	{
		this.gemaN8 = PlayerPrefs.GetInt("gemaN8", 0);
	}

	// Token: 0x060001CB RID: 459 RVA: 0x00006CD0 File Offset: 0x00004ED0
	private void Update()
	{
		
		if (gemaN8 == 1)
		{
			base.transform.position = new Vector3(2.01999998f,526.799988f,456.48999f);
		}
	}

}
