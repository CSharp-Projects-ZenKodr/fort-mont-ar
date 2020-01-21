using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoSpinner : MonoBehaviour {

    #region Public Variables
    /// <summary>
    /// Float value for the speed at which the GameObject will rotate.
    /// </summary>
    [Tooltip("Float value for the speed at which the GameObject will rotate.")]
    public float rotationSpeed = 0.0f;
    #endregion
	
	void Update () {
        SpinItAround();
	}

    void SpinItAround() {
        transform.Rotate(Vector3.down, rotationSpeed * Time.deltaTime);
    }
}