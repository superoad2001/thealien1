using System;
using UnityEngine;

// Token: 0x0200005F RID: 95
public class gema1 : MonoBehaviour
{
	// Token: 0x06000172 RID: 370 RVA: 0x000064A1 File Offset: 0x000046A1
	private void Start()
	{
	}

	// Token: 0x06000173 RID: 371 RVA: 0x000064A4 File Offset: 0x000046A4
	private void Update()
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		if (manager.gema1 == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x06000174 RID: 372 RVA: 0x000064D0 File Offset: 0x000046D0
	private void OnTriggerEnter(Collider col)
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		if (col.gameObject.tag == "Player")
		{
			if (manager.gemas >= 12)
			{
				manager.gemas++;
				manager.gema1 = 1;
				PlayerPrefs.SetInt("gemas", manager.gemas);
				PlayerPrefs.SetInt("gema1", manager.gema1);
			}
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}
}
