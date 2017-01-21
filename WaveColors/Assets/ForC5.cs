using UnityEngine;
using System.Collections;

public class ForC5 : MonoBehaviour {

	public void objGrowC5()
	{
		var maxSize = new Vector3 (6, 6, 6);

		if (transform.localScale != maxSize) {

			transform.localScale += new Vector3 (0.1f, 0.1f, 0.1f);


		} else

			transform.localScale = maxSize;			

	}

	public void objShrinkC5()
	{
		var minSize = new Vector3 (1, 1, 1);

		if (transform.localScale != minSize) {

			transform.localScale -= new Vector3 (0.1f, 0.1f, 0.1f);


		} else

			transform.localScale = minSize;	

	}
}
