using UnityEngine;
using System.Collections;

public class forC1 : MonoBehaviour {

	public float beamPower;
	public Rigidbody RB1;


	public void objGrowC1()
	{
		var maxSize = new Vector3 (6, 6, 6);

		if (transform.localScale != maxSize) {

			transform.localScale += new Vector3 (0.1f, 0.1f, 0.1f);


		} else

			transform.localScale = maxSize;			

	}

	public void objShrinkC1()
	{
		var minSize = new Vector3 (1, 1, 1);

		if (transform.localScale != minSize) {

			transform.localScale -= new Vector3 (0.1f, 0.1f, 0.1f);


		} else

			transform.localScale = minSize;	

	}

	public void ApplyForce(Rigidbody RB1)
	{

		Vector3 direction = transform.position - transform.position;
		RB1.AddForceAtPosition(direction.normalized, transform.position * beamPower);
	} 
}
