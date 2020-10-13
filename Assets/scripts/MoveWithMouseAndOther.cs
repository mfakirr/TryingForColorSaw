using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWithMouseAndOther : MonoBehaviour
{
	private Rigidbody rb;

	private Vector3 playerPos;
	private Vector3 playerStartPos;
    private Vector3 mousePos;
	private Vector3 mouseStartPos;

	forcube[] isfor;

	public levelconroller level;

	public int much;

    float farkx,farky,farkdegisimx,farkdegisimy;
    float rightco, leftco, upco, downco;
	public float bol, cangepos;


	private void Awake()
	{
	
		rb = GetComponent<Rigidbody>();
		int aa = gameObject.transform.childCount;
		for (int i = 0; i < aa; i++)
		{
			//isfor[i] = gameObject.GetComponentInChildren<forcube>();
			GameObject[] a = GameObject.FindGameObjectsWithTag("cube");
			if (a[i].GetComponent<forcube>().center)
			{
				much++;
			}
		
		}
		GameObject lev = GameObject.Find("levelling");
		level = lev.GetComponent<levelconroller>();
	
		
	}
	private void Update()
	{

		playerPos = rb.position;
		mousePos = Input.mousePosition;

		if (Input.GetMouseButtonDown(0))
		{
			
			mouseStartPos = mousePos;

		}
		if (Input.GetMouseButton(0))
		{
			farkx = mousePos.x - mouseStartPos.x;
			farky = mousePos.y - mouseStartPos.y;

			if (farkx>0)
			{//saga
				if (farkx<farkdegisimx)
				{//olduğu yerden tersine dönerse
					resetpos();
				}
				goright();
			}
			else if (farkx <= 0)
			{//sola
				if (farkx > farkdegisimx)
				{
					resetpos();
				}
				goleft();

			}
			if (farky>0)
			{
				if (farkdegisimy>farky)
				{
					resetpos();
				}
				goup();//aşağıdan yukarıya
			}else if (farky<0)
			{
				if (farkdegisimy < farky)
				{
					resetpos();
				}
				godown(); //yukarıdan aşağı
			}

			farkdegisimx = mousePos.x - mouseStartPos.x;
			farkdegisimy = mousePos.y - mouseStartPos.y;
		}
		
		if (gameObject.transform.childCount == much)
		{
			level.next();
		}


	}
	void resetpos()
	{
		farkx = 0;
		farkdegisimx = 0;
		mouseStartPos.x = mousePos.x;
		farky = 0;
		farkdegisimy = 0;
		mouseStartPos.y = mousePos.y;

	}

	void goright()
	{
		float howmuch = Mathf.RoundToInt(Mathf.Abs((farkx) / (bol*2)));
		if (howmuch > rightco)
		{
			transform.position = new Vector3(transform.position.x + 1, transform.position.y, transform.position.z);
		}
		rightco = howmuch;
	}
	void goleft()
	{
		float howmuchleft = Mathf.RoundToInt(Mathf.Abs((farkx) /( bol*2)));
		if (howmuchleft > leftco)
		{
			transform.position = new Vector3(transform.position.x - 1, transform.position.y, transform.position.z);
			
		}
		leftco = howmuchleft;
	}
	void goup()
	{
		float howmuchup = Mathf.RoundToInt(Mathf.Abs((farky) / bol));
		if (howmuchup > upco)
		{
			transform.position = new Vector3(transform.position.x , transform.position.y, transform.position.z +1);
		}
		upco = howmuchup;

	}
	void godown()
	{
		float howmuchdown = Mathf.RoundToInt(Mathf.Abs((farky) / bol));
		if (howmuchdown > downco)
		{
			transform.position= new Vector3(transform.position.x, transform.position.y, transform.position.z - 1);
		}
		downco = howmuchdown;

	}


	
}
