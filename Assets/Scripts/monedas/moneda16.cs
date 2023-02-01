using System;
using UnityEngine;

// Token: 0x0200002F RID: 47
public class moneda16 : MonoBehaviour
{
	public AudioSource audio1;
	// Token: 0x060000B2 RID: 178 RVA: 0x000048C7 File Offset: 0x00002AC7
	private void Start()
	{
	}

	// Token: 0x060000B3 RID: 179 RVA: 0x000048CC File Offset: 0x00002ACC
	private void Update()
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		base.transform.Rotate(Vector3.left, 200f * Time.deltaTime);
		if (manager.moneda16 == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x060000B4 RID: 180 RVA: 0x0000490C File Offset: 0x00002B0C
	private void OnTriggerEnter(Collider col)
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		manager.moneda16 = 1;
		manager.monedas++;
		PlayerPrefs.SetInt("monedas", manager.monedas);
		PlayerPrefs.SetInt("moneda16", manager.moneda16);
		audio1.Play();
		UnityEngine.Object.Destroy(base.gameObject);
	}
}
