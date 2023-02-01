using System;
using UnityEngine;

// Token: 0x0200004A RID: 74
public class moneda40 : MonoBehaviour
{
	public AudioSource audio1;
	// Token: 0x0600011E RID: 286 RVA: 0x000059A7 File Offset: 0x00003BA7
	private void Start()
	{
	}

	// Token: 0x0600011F RID: 287 RVA: 0x000059AC File Offset: 0x00003BAC
	private void Update()
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		base.transform.Rotate(Vector3.left, 200f * Time.deltaTime);
		if (manager.moneda40 == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x06000120 RID: 288 RVA: 0x000059EC File Offset: 0x00003BEC
	private void OnTriggerEnter(Collider col)
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		manager.moneda40 = 1;
		manager.monedas++;
		PlayerPrefs.SetInt("monedas", manager.monedas);
		PlayerPrefs.SetInt("moneda40", manager.moneda40);
		audio1.Play();
		UnityEngine.Object.Destroy(base.gameObject);
	}
}
