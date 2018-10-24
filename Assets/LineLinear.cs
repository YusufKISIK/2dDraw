using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineLinear : MonoBehaviour
{
	private LineRenderer lineR;
	
	// Use this for initialization
	void Start ()
	{
		lineR = GetComponent<LineRenderer>();
		
		Vector2 mousepos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		
		lineR.SetPosition(0,mousepos);
		
	}

	public void SetLastPoint(Vector2 position)
	{
		
		if (lineR != null)
		{
			lineR.SetPosition(1,position);	
		}
	}

	public void Destroy()
	{
		Destroy(gameObject);
	}
}
