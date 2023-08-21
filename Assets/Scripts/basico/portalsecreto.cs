using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class portalsecreto : MonoBehaviour
{
    public bool activar;
    public GameObject portal;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        manager2 manager = UnityEngine.Object.FindObjectOfType<manager2>();

        if(manager.recordnv1 <= 0 && manager.recordnv2 <= 0 && manager.recordnv3 <= 0 && manager.recordnv4 <= 0 && manager.recordnv5 <= 0 && manager.recordnv6 <= 0 && manager.recordnv7 <= 0 && manager.recordnv8 <= 0 && manager.recordnv9 <= 0 
        && manager.recordnv10 <= 0 && manager.recordnv11 <= 0 && manager.recordnv12 <= 0 && manager.recordnv13 <= 0 && manager.recordnv14 <= 0 && manager.recordnv15 <= 0)
        {
            activar = true;
            portal.SetActive(true);
        }
    }
    public void OnCollisionEnter(Collision col) 
    {
        if (col.gameObject.tag == "Player" && activar == true)
		{
			SceneManager.LoadScene("sala_secreta");
		}
    }
}
