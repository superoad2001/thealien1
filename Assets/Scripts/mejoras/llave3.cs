using System;
using UnityEngine;

// Token: 0x02000077 RID: 119
public class llave3 : MonoBehaviour
{
	// Token: 0x060001D2 RID: 466 RVA: 0x00006E4B File Offset: 0x0000504B
	private void Start()
	{
	}

	// Token: 0x060001D3 RID: 467 RVA: 0x00006E50 File Offset: 0x00005050
	private void Update()
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		if (manager.tengollave3 == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		if (manager.gemas >= 15 && manager.monedas >= 40)
		{
			base.transform.position = new Vector3(-0.52f, 526.902f, 451.59f);
		}
	}

	// Token: 0x060001D4 RID: 468 RVA: 0x00006EB4 File Offset: 0x000050B4
	private void OnTriggerEnter(Collider col)
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		if (col.gameObject.tag == "Player")
		{
			manager.tengollave3 = 1;
			PlayerPrefs.SetInt("llave3", manager.tengollave3);
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}
}
