using System;
using UnityEngine;

// Token: 0x02000029 RID: 41
public class moneda10 : MonoBehaviour
{
	public AudioSource audio1;
	// Token: 0x0600009A RID: 154 RVA: 0x00004503 File Offset: 0x00002703
	private void Start()
	{
	}

	// Token: 0x0600009B RID: 155 RVA: 0x00004508 File Offset: 0x00002708
	private void Update()
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		base.transform.Rotate(Vector3.left, 200f * Time.deltaTime);

		if (manager.moneda10 == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x0600009C RID: 156 RVA: 0x00004548 File Offset: 0x00002748
	private void OnTriggerEnter(Collider col)
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		manager.moneda10 = 1;
		manager.monedas++;
		PlayerPrefs.SetInt("monedas", manager.monedas);
		PlayerPrefs.SetInt("moneda10", manager.moneda10);
		audio1.Play();
		UnityEngine.Object.Destroy(base.gameObject);
	}
}
