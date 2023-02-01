using System;
using UnityEngine;

// Token: 0x02000050 RID: 80
public class moneda46 : MonoBehaviour
{
	public AudioSource audio1;
	// Token: 0x06000136 RID: 310 RVA: 0x00005D67 File Offset: 0x00003F67
	private void Start()
	{
	}

	// Token: 0x06000137 RID: 311 RVA: 0x00005D6C File Offset: 0x00003F6C
	private void Update()
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		base.transform.Rotate(Vector3.left, 200f * Time.deltaTime);
		if (manager.moneda46 == 1)
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x06000138 RID: 312 RVA: 0x00005DAC File Offset: 0x00003FAC
	private void OnTriggerEnter(Collider col)
	{
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		manager.moneda46 = 1;
		manager.monedas++;
		PlayerPrefs.SetInt("monedas", manager.monedas);
		PlayerPrefs.SetInt("moneda46", manager.moneda46);
		audio1.Play();
		UnityEngine.Object.Destroy(base.gameObject);
	}
}
