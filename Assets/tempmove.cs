using UnityEngine;
using System.Collections;

public class tempmove : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow))
		{
			Vector3 position = this.transform.position;
			position.y++;
			this.transform.position = position;
		}


	}
}
