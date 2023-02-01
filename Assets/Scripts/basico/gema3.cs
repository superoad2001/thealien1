using System;
using UnityEngine;

// Token: 0x02000061 RID: 97
public class gema3 : MonoBehaviour
{
	// Token: 0x0600017A RID: 378 RVA: 0x00006602 File Offset: 0x00004802
	private void Start()
	{
	}

	// Token: 0x0600017B RID: 379 RVA: 0x00006604 File Offset: 0x00004804
	private void Update()
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		if (manager.gema3 == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x0600017C RID: 380 RVA: 0x00006630 File Offset: 0x00004830
	private void OnTriggerEnter(Collider col)
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		if (col.gameObject.tag == "Player")
		{
			if (manager.gemas >= 12)
			{
				manager.gemas++;
				manager.gema3 = 1;
				PlayerPrefs.SetInt("gemas", manager.gemas);
				PlayerPrefs.SetInt("gema3", manager.gema3);
			}
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}
}
