using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EstoEsLoQueHaceQueDispare : MonoBehaviour {
	public int Bullets,puntaje;
	public GameObject BulletSprite;
    public Transform BulletSpwan;
    public int Naves;
    
    private delegate void Action();
    Action action;
    public bool claw;
    private Vector3 initClawPosition;
    private Vector3 finalClawPosition;
    public float clawSpeed;
    public GameObject daClawFinal;
    public GameObject daClaw;
    public bool daClawIsWorking;
    public bool isReturning;
    void Start()
    {
        daClawIsWorking = false;
        isReturning = false;
        finalClawPosition = daClawFinal.transform.localPosition;
        initClawPosition = daClaw.transform.localPosition;
        if (claw)
        {
            action = Claw;
        }
        else {
            action = Shoot;
        }
    }

    void Update()
    {
        BulletShoot();
    }

    public void Shoot() {
        Instantiate(BulletSprite, BulletSpwan.transform.position, BulletSpwan.transform.rotation);
    }
    public void Claw() {
        daClawIsWorking = true;
        if (daClaw.transform.localPosition.x < finalClawPosition.x && daClaw.transform.localPosition.y > finalClawPosition.y && !isReturning)
        {
            daClaw.transform.Translate(Vector3.right * 2 * Time.deltaTime);
            
        }
        else {
            if (daClaw.transform.localPosition.x > initClawPosition.x && daClaw.transform.localPosition.y < initClawPosition.y)
            {
                isReturning = true;
                daClaw.transform.Translate(Vector3.right * -2 * Time.deltaTime);
            }
            else {
                daClaw.transform.localPosition = initClawPosition;
                isReturning = false;
                daClawIsWorking = false;
            }
           
        }
       
    }
    public void BulletShoot()
	{
		if (Input.GetButtonDown("Fire1")|| daClawIsWorking)
		{
            action();
		}
      }
}