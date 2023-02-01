using System;
using UnityEngine;

// Token: 0x02000055 RID: 85
public class moneda50 : MonoBehaviour
{
	public AudioSource audio1;
	// Token: 0x0600014A RID: 330 RVA: 0x00006087 File Offset: 0x00004287
	private void Start()
	{
	}

	// Token: 0x0600014B RID: 331 RVA: 0x0000608C File Offset: 0x0000428C
	private void Update()
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		base.transform.Rotate(Vector3.left, 200f * Time.deltaTime);
		if (manager.moneda50 == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x0600014C RID: 332 RVA: 0x000060CC File Offset: 0x000042CC
	private void OnTriggerEnter(Collider col)
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		manager.moneda50 = 1;
		manager.monedas++;
		PlayerPrefs.SetInt("monedas", manager.monedas);
		PlayerPrefs.SetInt("moneda50", manager.moneda50);
		audio1.Play();
		UnityEngine.Object.Destroy(base.gameObject);
	}
}
