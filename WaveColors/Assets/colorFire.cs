using UnityEngine;
using System.Collections;

public class colorFire : MonoBehaviour {

	public bool beamRed, beamBlue; 
	public float beamPower;
	public Rigidbody cubeRB;
	public Transform cubeTF;
	public Material prisimColor;

	// Use this for initialization
	void Start () {

		beamRed = true;
		beamBlue = false;


	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown ("1")) {

			beamRed = true;
			beamBlue = false;

			//prisimColor.SetColor = Color.red;
		}

		if (Input.GetKeyDown ("2")) {

			beamRed = false;
			beamBlue = true;

			//prisimColor.SetColor = Color.blue;
		}




		if (Input.GetButton("Fire1")) {

			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;

			if (Physics.Raycast (ray, out hit, 100))
				Debug.DrawLine (ray.origin, hit.point);

			if(hit.collider && beamRed == true)
			{
				Vector3 dir = new Vector3 (10f, 10f, 10f);
				cubeRB.AddForce (beamPower * dir);

			
			}

			if(hit.collider && beamBlue == true)
			{
				//Vector3 dir = new Vector3 (10f, 0f, 10f);
				//cubeRB.AddForce (beamPower * dir);

				cubeTF.localScale = new Vector3 (1,1,1);
			}


		}
	
	}
}
