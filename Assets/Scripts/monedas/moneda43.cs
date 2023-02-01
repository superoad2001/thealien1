using System;
using UnityEngine;

// Token: 0x0200004D RID: 77
public class moneda43 : MonoBehaviour
{
	public AudioSource audio1;
	// Token: 0x0600012A RID: 298 RVA: 0x00005B87 File Offset: 0x00003D87
	private void Start()
	{
	}

	// Token: 0x0600012B RID: 299 RVA: 0x00005B8C File Offset: 0x00003D8C
	private void Update()
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		base.transform.Rotate(Vector3.left, 200f * Time.deltaTime);
		if (manager.moneda43 == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x0600012C RID: 300 RVA: 0x00005BCC File Offset: 0x00003DCC
	private void OnTriggerEnter(Collider col)
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		manager.moneda43 = 1;
		manager.monedas++;
		PlayerPrefs.SetInt("monedas", manager.monedas);
		PlayerPrefs.SetInt("moneda43", manager.moneda43);
		audio1.Play();
		UnityEngine.Object.Destroy(base.gameObject);
	}
}
