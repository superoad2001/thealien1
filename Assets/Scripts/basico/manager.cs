using System;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200000B RID: 11
public class manager : MonoBehaviour
{
	public int plat = 1;
	public AudioSource audio;
	public AudioSource audio1;
	public AudioSource audio2;
	public AudioSource audio3;
	public AudioSource audio4;
	public AudioSource audio5;
	public AudioSource audio6;
	public AudioSource audio7;
	public int plataforma;
	// Token: 0x06000025 RID: 37 RVA: 0x0000334C File Offset: 0x0000154C
	private void Awake() {
	{
		this.plataforma = PlayerPrefs.GetInt("plataforma", plat);
	}
	}
	private void Start()
	{
		jugador jugador = UnityEngine.Object.FindObjectOfType<jugador>();
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();



		this.tengomejora = PlayerPrefs.GetInt("tengomejora", 0);
		this.cinematicaf = PlayerPrefs.GetInt("cinfinal", 0);
		this.gema1 = PlayerPrefs.GetInt("gema1", 0);
		this.gema2 = PlayerPrefs.GetInt("gema2", 0);
		this.gema3 = PlayerPrefs.GetInt("gema3", 0);
		this.gemaN1 = PlayerPrefs.GetInt("gemaN1", 0);
		this.gemaN2 = PlayerPrefs.GetInt("gemaN2", 0);
		this.gemaN3 = PlayerPrefs.GetInt("gemaN3", 0);
		this.gemaN4 = PlayerPrefs.GetInt("gemaN4", 0);
		this.gemaN5 = PlayerPrefs.GetInt("gemaN5", 0);
		this.gemaN6 = PlayerPrefs.GetInt("gemaN6", 0);
		this.gemaN7 = PlayerPrefs.GetInt("gemaN7", 0);
		this.gemaN8 = PlayerPrefs.GetInt("gemaN8", 0);
		this.gemaN9 = PlayerPrefs.GetInt("gemaN9", 0);
		this.gemaN10 = PlayerPrefs.GetInt("gemaN10", 0);
		this.gemaN11 = PlayerPrefs.GetInt("gemaN11", 0);
		this.gemaN12 = PlayerPrefs.GetInt("gemaN12", 0);
		this.fragmento = PlayerPrefs.GetInt("fragmento", 0);
		this.fragmentoN1 = PlayerPrefs.GetInt("fragmentoN1", 0);
		this.fragmentoN2 = PlayerPrefs.GetInt("fragmentoN2", 0);
		this.fragmentoN3 = PlayerPrefs.GetInt("fragmentoN3", 0);
		this.tengosalto = PlayerPrefs.GetInt("salto", 0);
		this.tengocoche = PlayerPrefs.GetInt("coche", 0);
		this.tengovel = PlayerPrefs.GetInt("vel", 0);
		this.tengonave = PlayerPrefs.GetInt("nave", 0);
		this.gemas = PlayerPrefs.GetInt("gemas", 0);
		this.monedas = PlayerPrefs.GetInt("monedas", 0);
		this.tengollave1 = PlayerPrefs.GetInt("llave1", 0);
		this.tengollave2 = PlayerPrefs.GetInt("llave2", 0);
		this.tengollave3 = PlayerPrefs.GetInt("llave3", 0);
		this.tengollave4 = PlayerPrefs.GetInt("llave4", 0);
		this.moneda1 = PlayerPrefs.GetInt("moneda1", 0);
		this.moneda2 = PlayerPrefs.GetInt("moneda2", 0);
		this.moneda3 = PlayerPrefs.GetInt("moneda3", 0);
		this.moneda4 = PlayerPrefs.GetInt("moneda4", 0);
		this.moneda5 = PlayerPrefs.GetInt("moneda5", 0);
		this.moneda6 = PlayerPrefs.GetInt("moneda6", 0);
		this.moneda7 = PlayerPrefs.GetInt("moneda7", 0);
		this.moneda8 = PlayerPrefs.GetInt("moneda8", 0);
		this.moneda9 = PlayerPrefs.GetInt("moneda9", 0);
		this.moneda10 = PlayerPrefs.GetInt("moneda10", 0);
		this.moneda11 = PlayerPrefs.GetInt("moneda11", 0);
		this.moneda12 = PlayerPrefs.GetInt("moneda12", 0);
		this.moneda13 = PlayerPrefs.GetInt("moneda13", 0);
		this.moneda14 = PlayerPrefs.GetInt("moneda14", 0);
		this.moneda15 = PlayerPrefs.GetInt("moneda15", 0);
		this.moneda16 = PlayerPrefs.GetInt("moneda16", 0);
		this.moneda17 = PlayerPrefs.GetInt("moneda17", 0);
		this.moneda18 = PlayerPrefs.GetInt("moneda18", 0);
		this.moneda19 = PlayerPrefs.GetInt("moneda19", 0);
		this.moneda20 = PlayerPrefs.GetInt("moneda20", 0);
		this.moneda21 = PlayerPrefs.GetInt("moneda21", 0);
		this.moneda22 = PlayerPrefs.GetInt("moneda22", 0);
		this.moneda23 = PlayerPrefs.GetInt("moneda23", 0);
		this.moneda24 = PlayerPrefs.GetInt("moneda24", 0);
		this.moneda25 = PlayerPrefs.GetInt("moneda25", 0);
		this.moneda26 = PlayerPrefs.GetInt("moneda26", 0);
		this.moneda27 = PlayerPrefs.GetInt("moneda27", 0);
		this.moneda28 = PlayerPrefs.GetInt("moneda28", 0);
		this.moneda29 = PlayerPrefs.GetInt("moneda29", 0);
		this.moneda30 = PlayerPrefs.GetInt("moneda30", 0);
		this.moneda31 = PlayerPrefs.GetInt("moneda31", 0);
		this.moneda32 = PlayerPrefs.GetInt("moneda32", 0);
		this.moneda33 = PlayerPrefs.GetInt("moneda33", 0);
		this.moneda34 = PlayerPrefs.GetInt("moneda34", 0);
		this.moneda35 = PlayerPrefs.GetInt("moneda35", 0);
		this.moneda36 = PlayerPrefs.GetInt("moneda36", 0);
		this.moneda37 = PlayerPrefs.GetInt("moneda37", 0);
		this.moneda38 = PlayerPrefs.GetInt("moneda38", 0);
		this.moneda39 = PlayerPrefs.GetInt("moneda39", 0);
		this.moneda40 = PlayerPrefs.GetInt("moneda40", 0);
		this.moneda41 = PlayerPrefs.GetInt("moneda41", 0);
		this.moneda42 = PlayerPrefs.GetInt("moneda42", 0);
		this.moneda43 = PlayerPrefs.GetInt("moneda43", 0);
		this.moneda44 = PlayerPrefs.GetInt("moneda44", 0);
		this.moneda45 = PlayerPrefs.GetInt("moneda45", 0);
		this.moneda46 = PlayerPrefs.GetInt("moneda46", 0);
		this.moneda47 = PlayerPrefs.GetInt("moneda47", 0);
		this.moneda48 = PlayerPrefs.GetInt("moneda48", 0);
		this.moneda49 = PlayerPrefs.GetInt("moneda49", 0);
		this.moneda50 = PlayerPrefs.GetInt("moneda50", 0);

		if (this.piso == 1 && this.gemas == 0 && jugador.dentrotienda == false)
		{
			audio.Play();
		}
		if (this.piso == 1 && this.gemas >= 1 && this.gemas <= 3 && tengovel == 0 && jugador.dentrotienda == false)
		{
			audio1.Play();
		}
		
		if (this.piso == 1 && this.gemas >= 3 && this.gemas <= 6 && jugador.dentrotienda == false && tengovel == 1 && tengocoche == 0)
		{
			audio2.Play();
		}
		if (this.piso == 1 && this.gemas >= 6 && this.gemas <= 9 && tengocoche == 1 && jugador.dentrotienda == false && tengosalto == 0)
		{
			audio3.Play();
		}
		if (this.piso == 1 && this.gemas >= 9 && this.gemas <= 12 && tengosalto == 1 && jugador.dentrotienda == false && tengonave == 0)
		{
			audio4.Play();
		}
		if (this.piso == 1 && this.gemas >= 12 && tengonave == 1 && jugador.dentrotienda == false && espacio == 1 && fragmento < 3 && tengomejora == 0 && tengollave4 == 0)
		{
			audio5.Play();
		}
		if (this.piso == 1 && this.gemas == 15 && tengomejora == 0 && jugador.dentrotienda == false && fragmento == 3 && tengollave4 == 0 && monedas == 50)
		{
			audio6.Play();
		}
	}
	public bool mundos = false;
		// Token: 0x04000021 RID: 33
	public bool unavez = true;

	// Token: 0x04000022 RID: 34
	public GameObject jugador1;

	// Token: 0x04000023 RID: 35
	public GameObject jefe1;

	// Token: 0x04000024 RID: 36
	public Camera normal;

	// Token: 0x04000025 RID: 37
	public float tiement;

	// Token: 0x04000026 RID: 38
	public int juego;

	// Token: 0x04000027 RID: 39
	public bool tutorial;

	// Token: 0x04000028 RID: 40
	public int espacio = 0;

	public int gemas;

	public int gemaN1;

	public int gemaN2;

	public int gemaN3;

	public int gemaN4;

	public int gemaN5;

	public int gemaN6;

	public int gemaN7;

	public int gemaN8;

	public int gemaN9;

	public int gemaN10;

	public int gemaN11;

	public int gemaN12;

	public int fragmentoN1;

	public int fragmentoN2;

	public int fragmentoN3;

	public Text mision;

	public Text mision2;

	// Token: 0x04000029 RID: 41
	public Text cuentagemas;

	// Token: 0x0400002A RID: 42
	public Text cuentamonedas;

	// Token: 0x0400002B RID: 43
	public Text cuentafrag;

	// Token: 0x0400002C RID: 44
	public int monedas;

	// Token: 0x0400002D RID: 45
	public int tengovel;

	// Token: 0x0400002E RID: 46
	public int tengocoche;

	// Token: 0x0400002F RID: 47
	public int tengosalto;

	// Token: 0x04000030 RID: 48
	public int tengonave;

	// Token: 0x04000031 RID: 49
	public int piso = 0;

	// Token: 0x04000032 RID: 50
	public int fragmento;

	// Token: 0x04000033 RID: 51
	public int tengollave1;

	// Token: 0x04000034 RID: 52
	public int tengollave2;

	// Token: 0x04000035 RID: 53
	public int tengollave3;

	// Token: 0x04000036 RID: 54
	public int tengollave4;

	// Token: 0x04000037 RID: 55
	public int cinematicaf;

	// Token: 0x04000038 RID: 56
	public int tengomejora;

	// Token: 0x04000039 RID: 57
	public int gema1;

	// Token: 0x0400003A RID: 58
	public int gema2;

	// Token: 0x0400003B RID: 59
	public int gema3;

	// Token: 0x0400003C RID: 60
	public int moneda1;

	// Token: 0x0400003D RID: 61
	public int moneda2;

	// Token: 0x0400003E RID: 62
	public int moneda3;

	// Token: 0x0400003F RID: 63
	public int moneda4;

	// Token: 0x04000040 RID: 64
	public int moneda5;

	// Token: 0x04000041 RID: 65
	public int moneda6;

	// Token: 0x04000042 RID: 66
	public int moneda7;

	// Token: 0x04000043 RID: 67
	public int moneda8;

	// Token: 0x04000044 RID: 68
	public int moneda9;

	// Token: 0x04000045 RID: 69
	public int moneda10;

	// Token: 0x04000046 RID: 70
	public int moneda11;

	// Token: 0x04000047 RID: 71
	public int moneda12;

	// Token: 0x04000048 RID: 72
	public int moneda13;

	// Token: 0x04000049 RID: 73
	public int moneda14;

	// Token: 0x0400004A RID: 74
	public int moneda15;

	// Token: 0x0400004B RID: 75
	public int moneda16;

	// Token: 0x0400004C RID: 76
	public int moneda17;

	// Token: 0x0400004D RID: 77
	public int moneda18;

	// Token: 0x0400004E RID: 78
	public int moneda19;

	// Token: 0x0400004F RID: 79
	public int moneda20;

	// Token: 0x04000050 RID: 80
	public int moneda21;

	// Token: 0x04000051 RID: 81
	public int moneda22;

	// Token: 0x04000052 RID: 82
	public int moneda23;

	// Token: 0x04000053 RID: 83
	public int moneda24;

	// Token: 0x04000054 RID: 84
	public int moneda25;

	// Token: 0x04000055 RID: 85
	public int moneda26;

	// Token: 0x04000056 RID: 86
	public int moneda27;

	// Token: 0x04000057 RID: 87
	public int moneda28;

	// Token: 0x04000058 RID: 88
	public int moneda29;

	// Token: 0x04000059 RID: 89
	public int moneda30;

	// Token: 0x0400005A RID: 90
	public int moneda31;

	// Token: 0x0400005B RID: 91
	public int moneda32;

	// Token: 0x0400005C RID: 92
	public int moneda33;

	// Token: 0x0400005D RID: 93
	public int moneda34;

	// Token: 0x0400005E RID: 94
	public int moneda35;

	// Token: 0x0400005F RID: 95
	public int moneda36;

	// Token: 0x04000060 RID: 96
	public int moneda37;

	// Token: 0x04000061 RID: 97
	public int moneda38;

	// Token: 0x04000062 RID: 98
	public int moneda39;

	// Token: 0x04000063 RID: 99
	public int moneda40;

	// Token: 0x04000064 RID: 100
	public int moneda41;

	// Token: 0x04000065 RID: 101
	public int moneda42;

	// Token: 0x04000066 RID: 102
	public int moneda43;

	// Token: 0x04000067 RID: 103
	public int moneda44;

	// Token: 0x04000068 RID: 104
	public int moneda45;

	// Token: 0x04000069 RID: 105
	public int moneda46;

	// Token: 0x0400006A RID: 106
	public int moneda47;

	// Token: 0x0400006B RID: 107
	public int moneda48;

	// Token: 0x0400006C RID: 108
	public int moneda49;

	// Token: 0x0400006D RID: 109
	public int moneda50;

	// Token: 0x06000026 RID: 38 RVA: 0x000037BC File Offset: 0x000019BC
	private void Update()
	{
		jugador jugador = UnityEngine.Object.FindObjectOfType<jugador>();
		manager manager = UnityEngine.Object.FindObjectOfType<manager>();
		
		if (this.juego == 0 && this.piso == 1 && jugador.dentrotienda == false || this.juego == 0 && this.piso == 2 && jugador.dentrotienda == false|| this.juego == 0 && this.piso == 3 && jugador.dentrotienda == false|| this.juego == 0 && this.piso == 4 && jugador.dentrotienda == false)
		{
			this.cuentamonedas.text = "monedas:  " + this.monedas;
			this.cuentagemas.text = "gemas:  " + this.gemas;
			this.cuentafrag.text = "fragmentos de gran gema: " + this.fragmento + "/3";

			if (gemas == 0)
			{
				this.mision.text = "MISION: cruza una puerta y consigue una gema completando un nivel";
			}
			if (gemas == 1 && monedas < 10)
			{
				this.mision.text = "MISION: haz los 2 niveles que quedan y baja abajo y consigue 10 monedas";
			}
			if (gemas == 2 && monedas < 10)
			{
				this.mision.text = "MISION: haz el nivel que te queda y baja abajo y consigue 10 monedas";
			}
			if (gemas == 3 && monedas < 10)
			{
				this.mision.text = "MISION: baja abajo y consigue 10 monedas";
			}
			if (gemas == 1 && monedas == 10)
			{
				this.mision.text = "MISION: haz los 2 niveles que quedan";
			}
			if (gemas == 2 && monedas == 10)
			{
				this.mision.text = "MISION: haz el nivel que te queda";
			}
			if (gemas == 3 && monedas == 10 && tengovel == 0)
			{
				this.mision.text = "MISION: ve a la tienda del primer  piso y recoge el acelerador";
			}
			if (gemas <= 6 && monedas <= 20 && tengovel == 1)
			{
				this.mision.text = "MISION: sube al segundo piso y consigue 6 gemas  baja al espacio y llega a las 20 monedas usando el acelerador";
			}
			if (gemas == 6 && monedas == 20 && tengocoche == 0)
			{
				this.mision.text = "MISION: ve a la tienda y recoge tu nuevo coche";
			}
			if (gemas <= 9 && monedas <= 30 && tengocoche == 1)
			{
				this.mision.text = "MISION: sube al tercer piso y consigue 9 gemas                                                     baja al espacio y llega a las 30 monedas usando el coche para usarlo tocalo";
			}
			if (gemas == 9 && monedas == 30 && tengosalto == 0)
			{
				this.mision.text = "MISION: ve a la tienda y recoge el saltador";
			}
			if (gemas <= 12 && monedas <= 40 && tengosalto == 1)
			{
				this.mision.text = "MISION: sube al cuarto piso y consigue 12 gemas                                                     baja al espacio y llega a las 40 monedas usando el saltador";
			}
			if (gemas == 12 && monedas == 40 && tengonave == 0)
			{
				this.mision.text = "MISION: ve a la tienda y recoge la nave espacial";
			}
			if (gemas == 12 && monedas == 40 && tengonave == 1)
			{
				this.mision.text = "MISION fase 1: usa la nave espacial en tu propiedad tocandola en la zona libre y viaja a asteroides y llega a las 13 gemas";
			}
			if (gemas == 13 && tengonave == 1 && tengollave1 == 0)
			{
				this.mision.text = "MISION fase 1: ve a la tienda y recoge la llave secreta de las minas del piso 2 ";
			}
			if (gemas == 13 &&  tengonave == 1 && tengollave1 == 1 && tengollave2 == 0 && tengollave3 == 0)
			{
				this.mision.text = "MISION fase 1: usa la nave espacial en tu propiedad tocandola en la zona libre y viaja a asteroides y llega a las 14 gemas";
			}
			if (gemas == 14 && tengonave == 1 && tengollave1 == 1 && tengollave2 == 0)
			{
				this.mision.text = "MISION fase 1: ve a la tienda y recoge la llave secreta de las minas del piso 3 ";
			}
			if (gemas == 14 &&  tengonave == 1 && tengollave1 == 1 && tengollave2 == 1 && tengollave3 == 0)
			{
				this.mision.text = "MISION fase 1: usa la nave espacial en tu propiedad tocandola en la zona libre y viaja a asteroides y llega a las 15 gemas";
			}
			if (gemas == 15 && tengonave == 1 && tengollave1 == 1 && tengollave2 == 1 && tengollave3 == 0)
			{
				this.mision.text = "MISION fase 1: ve a la tienda y recoge la llave secreta de las minas del piso 4 ";
			}
			if (gemas == 14 && tengonave == 1 && tengollave1 == 0 && tengollave2 == 0)
			{
				this.mision.text = "MISION fase 1: ve a la tienda y recoge la llave secreta de las minas del piso 2 y 3 ";
			}
			if (gemas == 15 && tengonave == 1 && tengollave1 == 0 && tengollave2 == 0 && tengollave3 == 0)
			{
				this.mision.text = "MISION fase 1: ve a la tienda y recoge la llave secreta de las minas del piso 2,3 y 4 ";
			}
			if (tengollave1 == 1 && tengollave2 == 0 && tengollave3 == 0 && fragmento == 0)
			{
				this.mision2.text = "MISION fase 2: ve al segundo piso y consigue un fragmento de gran gema en el nivel secreto";
			}
			if (tengollave1 == 1 && tengollave2 == 1 && tengollave3 == 0 && fragmento == 0)
			{
				this.mision2.text = "MISION fase 2: ve al piso 2 y 3 y consigue un fragmento de gran gema en su respectivo nivel secreto";
			}
			if (tengollave1 == 1 && tengollave2 == 1 && tengollave3 == 1 && fragmento == 0)
			{
				this.mision2.text = "MISION fase 2: ve al piso 2, 3 y 4 y consigue un fragmento de gran gema en su respectivo nivel secreto";
			}
			if (tengollave1 == 1 && tengollave2 == 1 && tengollave3 == 0 && fragmento == 1 && fragmentoN1 == 0 && fragmentoN2 == 1)
			{
				this.mision2.text = "MISION fase 2: ve al segundo piso y consigue un fragmento de gran gema en el nivel secreto";
			}
			if (tengollave1 == 1 && tengollave2 == 1 && tengollave3 == 0 && fragmento == 1 && fragmentoN1 == 1 && fragmentoN2 == 0)
			{
				this.mision2.text = "MISION fase 2: ve al tercer piso y consigue un fragmento de gran gema en el nivel secreto";
			}
			if (tengollave1 == 1 && tengollave2 == 1 && tengollave3 == 1 && fragmento == 0 && fragmentoN1 == 0 && fragmentoN2 == 0 && fragmentoN3 == 0)
			{
				this.mision2.text = "MISION fase 2: ve al piso 2, 3 y 4 y consigue un fragmento de gran gema en su respectivo nivel secreto";
			}
			if (tengollave1 == 1 && tengollave2 == 1 && tengollave3 == 1 && fragmento == 1 && fragmentoN1 == 1 && fragmentoN2 == 0 && fragmentoN3 == 0)
			{
				this.mision2.text = "MISION fase 2: ve al piso 3 y 4 y consigue un fragmento de gran gema en su respectivo nivel secreto";
			}
			if (tengollave1 == 1 && tengollave2 == 1 && tengollave3 == 1 && fragmento == 2 && fragmentoN1 == 1 && fragmentoN2 == 1 && fragmentoN3 == 0)
			{
				this.mision2.text = "MISION fase 2: ve al cuarto piso y consigue un fragmento de gran gema en el nivel secreto";
			}
			if (tengollave1 == 1 && tengollave2 == 1 && tengollave3 == 1 && fragmento == 1 && fragmentoN1 == 0 && fragmentoN2 == 0 && fragmentoN3 == 1)
			{
				this.mision2.text = "MISION fase 2: ve al piso 2 y 3 y consigue un fragmento de gran gema en su respectivo nivel secreto";
			}
			if (tengollave1 == 1 && tengollave2 == 1 && tengollave3 == 1 && fragmento == 2 && fragmentoN1 == 0 && fragmentoN2 == 1 && fragmentoN3 == 1)
			{
				this.mision2.text = "MISION fase 2: ve al segundo piso y consigue un fragmento de gran gema en el nivel secreto";
			}
			if (tengollave1 == 1 && tengollave2 == 1 && tengollave3 == 1 && fragmento == 1 && fragmentoN1 == 0 && fragmentoN2 == 1 && fragmentoN3 == 0)
			{
				this.mision2.text = "MISION fase 2: ve al piso 2 y 4 y consigue un fragmento de gran gema en su respectivo nivel secreto";
			}
			if (tengollave1 == 1 && tengollave2 == 1 && tengollave3 == 1 && fragmento == 2 && fragmentoN1 == 1 && fragmentoN2 == 0 && fragmentoN3 == 1)
			{
				this.mision2.text = "MISION fase 2: ve al tercer piso y consigue un fragmento de gran gema en el nivel secreto";
			}
			if (fragmento == 3 && monedas < 50 && tengollave4 == 0)
			{
				this.mision.text = "MISION fase 3: consigue 50 monedas por el espacio";
			}
			if (fragmento == 3 && monedas == 50 && tengollave4 == 0)
			{
				this.mision.text = "MISION fase 3: ve a la tienda y recoje la llave del quinto piso";
			}

			if (fragmento == 3 && tengollave4 == 1 && tengomejora == 0)
			{
				this.mision.text = "MISION fase 3: recoje el hiperpropulsor en el quinto piso";
			}
			if (fragmento == 3 && tengomejora == 1)
			{
				this.mision.text = "MISION fase final: ve al espacio con la nave y largate de esta galaxia                 has desbloqueado la torre del tiempo sube arriba del quinto piso y supera tus records";
			}
			

			
		}
		if (piso == 5 && tengomejora == 1)
		{
			this.mision.text = "MISION fase final: ve al espacio con la nave y largate de esta galaxia                 has desbloqueado la torre del tiempo sube arriba del quinto piso y supera tus records";
		}
		if (this.juego == 4 && this.piso == 10 || this.juego == 1 && this.piso == 10 || this.juego == 4 && this.piso == 1)
		{
			this.cuentamonedas.text = "monedas:  " + this.monedas;
		}
				if (this.juego == 4 && this.piso == 10 && this.mundos == true || this.juego == 1 && this.piso == 10 && this.mundos == true || this.juego == 4 && this.piso == 1 && this.mundos == true )
		{
			this.cuentagemas.text = "gemas:  " + this.gemas;
		}
		if (juego == 6 && tengomejora == 1)
		{
			this.mision.text = "MISION fase final: vuela arriba a la plataforma de aterrizaje y sal de esta galaxia";
		}

	}


}
