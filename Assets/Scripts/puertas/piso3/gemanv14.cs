using System;
using UnityEngine;

// Token: 0x02000075 RID: 117
public class gemanv14 : MonoBehaviour
{
	private int fragmentoN2 = 0;
	// Token: 0x060001CA RID: 458 RVA: 0x00006CCD File Offset: 0x00004ECD
	private void Start()
	{
		this.fragmentoN2 = PlayerPrefs.GetInt("fragmentoN2", 0);
	}

	// Token: 0x060001CB RID: 459 RVA: 0x00006CD0 File Offset: 0x00004ED0
	private void Update()
	{
		
		if (fragmentoN2 == 1)
		{
			base.transform.position = new Vector3(-2.0999999f,526.799988f,443.399994f);
		}
	}

}
