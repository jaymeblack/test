using UnityEngine;
using System.Collections;

public class LesserDogBehavior : MonoBehaviour 
{
	public GameObject head;
	public GameObject neck;
	public GameObject body;
	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update(){
		if(Input.GetKey(KeyCode.Space))
		{
			head.SetActive(false);
		}
		else
		{
			head.SetActive(true);
		}
	}
	void OffScreenBehavior()
	{
		
	}

}
