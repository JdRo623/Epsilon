using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EstoEsLoQueHaceQueDispare : MonoBehaviour {
	public int Bullets,puntaje;
	public GameObject BulletSprite;
    public Transform BulletSpwan;
    public int Naves;

    private void Update()
    {
        BulletShoot();
    }

    public void BulletShoot()
	{
		if (Input.GetButtonDown("Fire1"))
		{								
			Instantiate (BulletSprite, BulletSpwan.transform.position, BulletSpwan.transform.rotation);
		
		}
      }
}