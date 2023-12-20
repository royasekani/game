using UnityEngine;
using System.Collections;

public class left : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnMouseDrag()
    {
        if (GameObject.Find("bazikon").transform.position.x > -2.59)
        {
            GameObject.Find("bazikon").transform.position -= new Vector3(0.2f, 0, 0);
        }
    }
}
