using System;
using UnityEngine;

// Token: 0x02000075 RID: 117
public class llave1 : MonoBehaviour
{
	// Token: 0x060001CA RID: 458 RVA: 0x00006CCD File Offset: 0x00004ECD
	private void Start()
	{
	}

	// Token: 0x060001CB RID: 459 RVA: 0x00006CD0 File Offset: 0x00004ED0
	private void Update()
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		if (manager.tengollave1 == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		if (manager.gemas >= 13 && manager.monedas >= 40)
		{
			base.transform.position = new Vector3(-0.32f, 526.902f, 451.59f);
		}
	}

	// Token: 0x060001CC RID: 460 RVA: 0x00006D34 File Offset: 0x00004F34
	private void OnTriggerEnter(Collider col)
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		if (col.gameObject.tag == "Player")
		{
			manager.tengollave1 = 1;
			PlayerPrefs.SetInt("llave1", manager.tengollave1);
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}
}
