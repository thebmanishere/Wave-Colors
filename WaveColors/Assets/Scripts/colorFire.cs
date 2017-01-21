using UnityEngine;
using System.Collections;

public class colorFire : MonoBehaviour {

	public bool beamRed, beamGreen, beamBlue; 
	public float beamPower;

	public forC1 C1;
	public ForC2 C2;
	public ForC3 C3;
	public ForC4 C4;
	public ForC5 C5;

	public Material prisimColor;

	void Start () {

		beamRed = true;
		beamBlue = false;
		beamGreen = false;

	
	}
	

	void Update () {

		if (Input.GetKeyDown ("1")) { //For the red beam 

			beamRed = true;
			beamGreen = false;
			beamBlue = false;




	
		}

		if (Input.GetKeyDown ("2")) { //For the green beam 

			beamRed = false;
			beamGreen = true;
			beamBlue = false;



		}



		if (Input.GetKeyDown ("3")) { //For the blue beam 

			beamRed = false;
			beamGreen = false;
			beamBlue = true;



		}

	



		if (Input.GetButton("Fire1")) { 

			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;

			if (Physics.Raycast (ray, out hit, 100))
				Debug.DrawLine (ray.origin, hit.point);

			if(hit.collider.CompareTag("C1") && beamRed == true)
			{
				//C1.ApplyForce(RB1);	
			}

			//////////////////////////////////////////////////////

			if(hit.collider.CompareTag("C1") && beamBlue == true)
			{
				Debug.Log ("Script has been called for c1 (shrink)");
				C1.objShrinkC1 ();

			
			} else

			if(hit.collider.CompareTag("C2") && beamBlue == true)
			{
				Debug.Log ("Script has been called for c2 (shrink)");
				C2.objShrinkC2();


				} else

			if(hit.collider.CompareTag("C3") && beamBlue == true)
			{
				Debug.Log ("Script has been called for c3 (shrink)");
				C3.objShrinkC3();


			}  else

			if(hit.collider.CompareTag("C4") && beamBlue == true)
			{
				Debug.Log ("Script has been called for c4 (shrink)");
				C4.objShrinkC4();

			} 	else

			if(hit.collider.CompareTag("C5") && beamBlue == true)
			{
				Debug.Log ("Script has been called for c5 (shrink)");
				C5.objShrinkC5();
			} 

			//////////////////////////////////////////////////////



			if(hit.collider.CompareTag("C1") && beamGreen == true)
			{
				Debug.Log ("Script has been called for c1 (Grow)");
				C1.objGrowC1 ();
			} 

				


			if(hit.collider.CompareTag("C2") && beamGreen == true)
			{
				Debug.Log ("Script has been called c2 (Grow)");
				C2.objGrowC2 ();
			} 
				

			if(hit.collider.CompareTag("C3") && beamGreen == true)
			{
				Debug.Log ("Script has been called c3 (Grow)");
				C3.objGrowC3 ();
			} 
					

			if(hit.collider.CompareTag("C4") && beamGreen == true)
			{
				Debug.Log ("Script has been called for c4 (shrink)");
				C4.objGrowC4();
			} 
						

			if(hit.collider.CompareTag("C5") && beamGreen == true)
			{
				Debug.Log ("Script has been called for c5 (shrink)");
				C5.objGrowC5();
			} 



		}
	
	}

	/*
	public void ApplyForce(Rigidbody RB1)
	{

		Vector3 direction = transform.position - transform.position;
		RB1.AddForceAtPosition(direction.normalized, transform.position * beamPower);
	} */



}
