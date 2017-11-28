using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundaryBehaviour : Utilities {

    public float BoundaryPositionOffset = 0.5f;
    private float _boundaryScaleOffset;

	// Use this for initialization
	void Start () {

        _boundaryScaleOffset = (BoundaryPositionOffset + 0.5f) *2;

		if (gameObject.name == "BoundaryU") {
			gameObject.transform.position = new Vector2 (0.0f, GetMaxVerticalPosition() + BoundaryPositionOffset);
			gameObject.transform.localScale = new Vector2 (GetMaxHorizontalPosition () - GetMinHorizontalPosition () + _boundaryScaleOffset, 1.0f);
		} else if (gameObject.name == "BoundaryR") {
			gameObject.transform.position = new Vector2 (GetMaxHorizontalPosition() + BoundaryPositionOffset, 0.0f);
			gameObject.transform.localScale = new Vector2 (1.0f, GetMaxVerticalPosition() - GetMinVerticalPosition() + _boundaryScaleOffset);
		} else if (gameObject.name == "BoundaryD") {
			gameObject.transform.position = new Vector2 (0.0f, GetMinVerticalPosition() - BoundaryPositionOffset);
			gameObject.transform.localScale = new Vector2 (GetMaxHorizontalPosition () - GetMinHorizontalPosition () + _boundaryScaleOffset, 1.0f);
		} else if (gameObject.name == "BoundaryL") {
			gameObject.transform.position = new Vector2 (GetMinHorizontalPosition() - BoundaryPositionOffset, 0.0f);
			gameObject.transform.localScale = new Vector2 (1.0f, GetMaxVerticalPosition() - GetMinVerticalPosition() + _boundaryScaleOffset);
		} else {
			Debug.Log("ERRO!! uma bondary esta com nome errado");
			GameObject.Destroy (gameObject);
		}
	}
}
