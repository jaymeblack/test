using UnityEngine;
using System.Collections;

public class ClickBehavior : MonoBehaviour 
{
	GameObject ldHead;
	GameObject ldNeck;
	void Update () 
	{
		if (Input.GetMouseButtonUp (0)) {
			MoveHead ();
			if (ldHead.transform.position.y < 9) {
				AddNeck ();
			}
		}
	}
	void Start () 
	{

		ldHead = GameObject.Find("Head");
		ldNeck = GameObject.Find("Neck");
		ldNeck.transform.localScale = new Vector3 (2, 10, 0);
	}

	void MoveHead()
	{
		Vector3 temp = ldHead.transform.position;
		temp.y += 0.1f;
		ldHead.transform.position = temp;
	}
	void AddNeck()
	{
		Instantiate(ldNeck, new Vector3(ldHead.transform.position.x,ldHead.transform.position.y - 0.5f, ldHead.transform.position.z), Quaternion.identity);
	}

}