using System;
using UnityEngine;

// Token: 0x02000073 RID: 115
public class recojemejora : MonoBehaviour
{
	// Token: 0x060001C2 RID: 450 RVA: 0x00006C14 File Offset: 0x00004E14
	private void Start()
	{
	}

	// Token: 0x060001C3 RID: 451 RVA: 0x00006C18 File Offset: 0x00004E18
	private void Update()
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		if (manager.tengomejora == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x060001C4 RID: 452 RVA: 0x00006C44 File Offset: 0x00004E44
	private void OnTriggerEnter(Collider col)
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		if (col.gameObject.tag == "Player")
		{
			manager.tengomejora = 1;
			PlayerPrefs.SetInt("tengomejora", manager.tengomejora);
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}
}
