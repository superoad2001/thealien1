using System;
using UnityEngine;

// Token: 0x02000076 RID: 118
public class llave2 : MonoBehaviour
{
	// Token: 0x060001CE RID: 462 RVA: 0x00006D8B File Offset: 0x00004F8B
	private void Start()
	{
	}

	// Token: 0x060001CF RID: 463 RVA: 0x00006D90 File Offset: 0x00004F90
	private void Update()
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		if (manager.tengollave2 == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		if (manager.gemas >= 14 && manager.monedas >= 40)
		{
			base.transform.position = new Vector3(-0.12f, 526.902f, 451.59f);
		}
	}

	// Token: 0x060001D0 RID: 464 RVA: 0x00006DF4 File Offset: 0x00004FF4
	private void OnTriggerEnter(Collider col)
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		if (col.gameObject.tag == "Player")
		{
			manager.tengollave2 = 1;
			PlayerPrefs.SetInt("llave2", manager.tengollave2);
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}
}
