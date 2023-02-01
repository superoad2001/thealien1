using System;
using UnityEngine;

// Token: 0x0200004C RID: 76
public class moneda42 : MonoBehaviour
{
	public AudioSource audio1;
	// Token: 0x06000126 RID: 294 RVA: 0x00005AE7 File Offset: 0x00003CE7
	private void Start()
	{
	}

	// Token: 0x06000127 RID: 295 RVA: 0x00005AEC File Offset: 0x00003CEC
	private void Update()
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		base.transform.Rotate(Vector3.left, 200f * Time.deltaTime);
		if (manager.moneda42 == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x06000128 RID: 296 RVA: 0x00005B2C File Offset: 0x00003D2C
	private void OnTriggerEnter(Collider col)
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		manager.moneda42 = 1;
		manager.monedas++;
		PlayerPrefs.SetInt("monedas", manager.monedas);
		PlayerPrefs.SetInt("moneda42", manager.moneda42);
		audio1.Play();
		UnityEngine.Object.Destroy(base.gameObject);
	}
}
