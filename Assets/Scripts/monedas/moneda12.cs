using System;
using UnityEngine;

// Token: 0x0200002B RID: 43
public class moneda12 : MonoBehaviour
{
	public AudioSource audio1;
	// Token: 0x060000A2 RID: 162 RVA: 0x0000464A File Offset: 0x0000284A
	private void Start()
	{
	}

	// Token: 0x060000A3 RID: 163 RVA: 0x0000464C File Offset: 0x0000284C
	private void Update()
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		base.transform.Rotate(Vector3.left, 200f * Time.deltaTime);
		if (manager.moneda12 == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x060000A4 RID: 164 RVA: 0x0000468C File Offset: 0x0000288C
	private void OnTriggerEnter(Collider col)
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		manager.moneda12 = 1;
		manager.monedas++;
		PlayerPrefs.SetInt("monedas", manager.monedas);
		PlayerPrefs.SetInt("moneda12", manager.moneda12);
		audio1.Play();
		UnityEngine.Object.Destroy(base.gameObject);
	}
}
