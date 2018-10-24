using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lineCreating : MonoBehaviour {

	public int LineFadeTime;

	static public bool MouseButtonUp = false;

	public GameObject linePrefab;

	public static LineLinear activeLine;

	private void Start()
	{
		
	}


	void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
			Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			RaycastHit2D hit = Physics2D.Raycast(mousePos, -Vector2.up);
			if (hit.collider != null)
			{
				Debug.Log("HIT");
				if (hit.collider.tag.Equals("dot")) {
					Debug.Log("HIT - DOT");
					GameObject lineGo = Instantiate(linePrefab);
					activeLine = lineGo.GetComponent<LineLinear>();
				}
			}
			
			
			
			
		}
		if (Input.GetMouseButton(0))
		{
			if (activeLine != null)
			{
				Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
				activeLine.SetLastPoint(mousePos);
			}
		}
		if (Input.GetMouseButtonUp(0))
		{
			Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			RaycastHit2D hit = Physics2D.Raycast(mousePos, -Vector2.up);
			if (hit.collider != null)
			{
				if (hit.collider.tag.Equals("dot"))
				{
					activeLine = null;
				}
			}
			else
			{
				
				activeLine.Destroy();
				activeLine = null;
			}
		}
	}
}
