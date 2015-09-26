using UnityEngine;
using System.Collections;


[RequireComponent(typeof(SpriteRenderer))]
public class Tile : MonoBehaviour {

	public SpriteRenderer rend;

	void Awake () {
		rend = this.gameObject.GetComponent<SpriteRenderer>();
	}
	

}
