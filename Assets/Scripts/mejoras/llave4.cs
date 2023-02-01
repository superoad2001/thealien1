using System;
using UnityEngine;

// Token: 0x02000078 RID: 120
public class llave4 : MonoBehaviour
{
	// Token: 0x060001D6 RID: 470 RVA: 0x00006F0B File Offset: 0x0000510B
	private void Start()
	{
	}

	// Token: 0x060001D7 RID: 471 RVA: 0x00006F10 File Offset: 0x00005110
	private void Update()
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		if (manager.tengollave4 == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		if (manager.gemas >= 15 && manager.monedas >= 50 && manager.fragmento >= 3)
		{
			base.transform.position = new Vector3(-0.32f, 526.902f, 451.59f);
		}
	}

	// Token: 0x060001D8 RID: 472 RVA: 0x00006F80 File Offset: 0x00005180
	private void OnTriggerEnter(Collider col)
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		if (col.gameObject.tag == "Player")
		{
			manager.tengollave4 = 1;
			PlayerPrefs.SetInt("llave4", manager.tengollave4);
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}
}
