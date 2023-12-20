using UnityEngine;
using System.Collections;

public class tolidgolule : MonoBehaviour {
    public GameObject prefab;
    public GameObject tir;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnMouseDown()
    {
        
        tir = Instantiate(prefab, new Vector3(GameObject.Find("bazikon").transform.position.x, GameObject.Find("bazikon").transform.position.y, 0), Quaternion.identity) as GameObject;
        GetComponent <AudioSource> ().Play();
    
    }
}
