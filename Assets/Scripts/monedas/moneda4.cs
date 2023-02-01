using System;
using UnityEngine;

// Token: 0x02000049 RID: 73
public class moneda4 : MonoBehaviour
{
	public AudioSource audio1;
	// Token: 0x0600011A RID: 282 RVA: 0x00005907 File Offset: 0x00003B07
	private void Start()
	{
	}

	// Token: 0x0600011B RID: 283 RVA: 0x0000590C File Offset: 0x00003B0C
	private void Update()
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
				base.transform.Rotate(Vector3.left, 200f * Time.deltaTime);

		if (manager.moneda4 == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x0600011C RID: 284 RVA: 0x0000594C File Offset: 0x00003B4C
	private void OnTriggerEnter(Collider col)
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		manager.moneda4 = 1;
		manager.monedas++;
		PlayerPrefs.SetInt("monedas", manager.monedas);
		PlayerPrefs.SetInt("moneda4", manager.moneda4);	
		audio1.Play();
		UnityEngine.Object.Destroy(base.gameObject);
	}
}
