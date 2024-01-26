﻿using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using Rewired;

// Token: 0x02000011 RID: 17
public class subircin2_al1 : MonoBehaviour
{
	public bool botonm = false;
	public GameObject tactil;
	[SerializeField]private int playerID = 0;
	[SerializeField]private Player player;
	// Token: 0x06000038 RID: 56 RVA: 0x00003A94 File Offset: 0x00001C94
	private void Start()
	{
		player = ReInput.players.GetPlayer(playerID);
		manager_al1 manager = UnityEngine.Object.FindObjectOfType<manager_al1>();
		if(manager.datosserial.plat == 1)
		{
			tactil.SetActive(false);
		}
		if(manager.datosserial.plat == 2)
		{
			tactil.SetActive(true);
		}
	}

	// Token: 0x06000039 RID: 57 RVA: 0x00003A96 File Offset: 0x00001C96
	private void Update()
	{
		if (player.GetAxis("b") > 0f || botonm == true)
		{
			SceneManager.LoadScene("espacio");
		}
	}
	public void boton_m()
    {
        botonm = true;
    }
	public void Detenerm()
    {
        botonm = false;
    }
}
