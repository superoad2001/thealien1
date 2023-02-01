using System;
using UnityEngine;

// Token: 0x0200007B RID: 123
public class tiendasalto : MonoBehaviour
{
	// Token: 0x060001E2 RID: 482 RVA: 0x0000716E File Offset: 0x0000536E
	private void Start()
	{
	}

	// Token: 0x060001E3 RID: 483 RVA: 0x00007170 File Offset: 0x00005370
	private void Update()
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		if (manager.tengosalto == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		if (manager.gemas >= 9 && manager.monedas >= 30)
		{
			base.transform.position = new Vector3(-5.56f, 527.46f, 450.05f);
		}
	}

	// Token: 0x060001E4 RID: 484 RVA: 0x000071D4 File Offset: 0x000053D4
	private void OnTriggerEnter(Collider col)
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		if (col.gameObject.tag == "Player")
		{
			manager.tengosalto = 1;
			PlayerPrefs.SetInt("salto", manager.tengosalto);
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}
}
