using System;
using UnityEngine;

// Token: 0x02000047 RID: 71
public class moneda38 : MonoBehaviour
{
	public AudioSource audio1;
	// Token: 0x06000112 RID: 274 RVA: 0x000057C7 File Offset: 0x000039C7
	private void Start()
	{
	}

	// Token: 0x06000113 RID: 275 RVA: 0x000057CC File Offset: 0x000039CC
	private void Update()
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		base.transform.Rotate(Vector3.left, 200f * Time.deltaTime);
		if (manager.moneda38 == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x06000114 RID: 276 RVA: 0x0000580C File Offset: 0x00003A0C
	private void OnTriggerEnter(Collider col)
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		manager.moneda38 = 1;
		manager.monedas++;
		PlayerPrefs.SetInt("monedas", manager.monedas);
		PlayerPrefs.SetInt("moneda38", manager.moneda38);
		audio1.Play();
		UnityEngine.Object.Destroy(base.gameObject);
	}
}
