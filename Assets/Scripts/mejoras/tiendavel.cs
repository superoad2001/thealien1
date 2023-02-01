using System;
using UnityEngine;

// Token: 0x0200007C RID: 124
public class tiendavel : MonoBehaviour
{
	// Token: 0x060001E6 RID: 486 RVA: 0x0000722B File Offset: 0x0000542B
	private void Start()
	{
	}

	// Token: 0x060001E7 RID: 487 RVA: 0x00007230 File Offset: 0x00005430
	private void Update()
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		if (manager.tengovel == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		if (manager.gemas >= 3 && manager.monedas >= 10)
		{
			base.transform.position = new Vector3(4.77f, 527.46f, 450.05f);
		}
	}

	// Token: 0x060001E8 RID: 488 RVA: 0x00007294 File Offset: 0x00005494
	private void OnTriggerEnter(Collider col)
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		if (col.gameObject.tag == "Player")
		{
			manager.tengovel = 1;
			PlayerPrefs.SetInt("vel", manager.tengovel);
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}
}
