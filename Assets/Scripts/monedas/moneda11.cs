using System;
using UnityEngine;

// Token: 0x0200002A RID: 42
public class moneda11 : MonoBehaviour
{
	public AudioSource audio1;
	// Token: 0x0600009E RID: 158 RVA: 0x000045A3 File Offset: 0x000027A3
	private void Start()
	{
	}

	// Token: 0x0600009F RID: 159 RVA: 0x000045A8 File Offset: 0x000027A8
	private void Update()
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		base.transform.Rotate(Vector3.left, 200f * Time.deltaTime);
		if (manager.moneda11 == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x060000A0 RID: 160 RVA: 0x000045E8 File Offset: 0x000027E8
	private void OnTriggerEnter(Collider col)
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		manager.moneda11 = 1;
		manager.monedas++;
		PlayerPrefs.SetInt("monedas", manager.monedas);
		PlayerPrefs.SetInt("moneda11", manager.moneda11);
		audio1.Play();
		UnityEngine.Object.Destroy(base.gameObject);
	}
}
