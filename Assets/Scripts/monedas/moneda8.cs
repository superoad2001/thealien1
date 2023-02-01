using System;
using UnityEngine;

// Token: 0x02000058 RID: 88
public class moneda8 : MonoBehaviour
{
	public AudioSource audio1;
	// Token: 0x06000156 RID: 342 RVA: 0x00006267 File Offset: 0x00004467
	private void Start()
	{
	}

	// Token: 0x06000157 RID: 343 RVA: 0x0000626C File Offset: 0x0000446C
	private void Update()
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		base.transform.Rotate(Vector3.left, 200f * Time.deltaTime);
		
		if (manager.moneda8 == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x06000158 RID: 344 RVA: 0x000062AC File Offset: 0x000044AC
	private void OnTriggerEnter(Collider col)
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		manager.moneda8 = 1;
		manager.monedas++;
		PlayerPrefs.SetInt("monedas", manager.monedas);
		PlayerPrefs.SetInt("moneda8", manager.moneda8);
		audio1.Play();
		UnityEngine.Object.Destroy(base.gameObject);
	}
}
