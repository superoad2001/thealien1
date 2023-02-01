using System;
using UnityEngine;

// Token: 0x02000060 RID: 96
public class gema2 : MonoBehaviour
{
	// Token: 0x06000176 RID: 374 RVA: 0x00006552 File Offset: 0x00004752
	private void Start()
	{
	}

	// Token: 0x06000177 RID: 375 RVA: 0x00006554 File Offset: 0x00004754
	private void Update()
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		if (manager.gema2 == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x06000178 RID: 376 RVA: 0x00006580 File Offset: 0x00004780
	private void OnTriggerEnter(Collider col)
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		if (col.gameObject.tag == "Player")
		{
			if (manager.gemas >= 12)
			{
				manager.gemas++;
				manager.gema2 = 1;
				PlayerPrefs.SetInt("gemas", manager.gemas);
				PlayerPrefs.SetInt("gema2", manager.gema2);
			}
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}
}
