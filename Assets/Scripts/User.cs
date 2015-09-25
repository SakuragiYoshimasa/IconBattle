using UnityEngine;
using System.Collections;

public class User : MonoBehaviour {

	public Texture2D icon;
	public GameObject tile;
	public GameObject tileInstance;
	public float numOfBlockPixel;

	public readonly int blockNum = 32;

	// Use this for initialization
	void Start () {

		int width = icon.width;
		//int height = icon.height;

		//Debug.Log(width.ToString());

		numOfBlockPixel =  (float)width / blockNum;
		int num = 0;
		for(int blockW = 0; blockW < blockNum; blockW++){
			for(int blockH = 0; blockH < blockNum; blockH++){

				Color32[] colors = new Color32[(int)numOfBlockPixel * (int)numOfBlockPixel];
				for(int w = blockW * (int)numOfBlockPixel; w < blockW *  (int)numOfBlockPixel + numOfBlockPixel; w++){
					for(int h = blockH * (int)numOfBlockPixel; h < blockH *  (int)numOfBlockPixel + numOfBlockPixel; h++){
						colors[(w - blockW *  (int)numOfBlockPixel) * (int)numOfBlockPixel + (h - blockH *  (int)numOfBlockPixel)] = icon.GetPixel(w,h);
					}
				}
				tileInstance = GameObject.Instantiate(tile,new Vector3(0.3f * blockW,0.3f * blockH,0),Quaternion.identity) as GameObject;
				tileInstance.transform.localScale = new Vector3(2f,2f,1f);
				tileInstance.gameObject.GetComponent<SpriteRenderer>().color = SmoothingColor(colors);
				num ++;
			}
		}
		Debug.Log(num.ToString());
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	Color32 SmoothingColor(Color32[] colors){
		byte r = 0;
		byte g = 0;
		byte b = 0;
		byte a = 0;

		for(int i = 0; i < numOfBlockPixel; i++){
			r += (byte)((float)colors[i].r / (float)numOfBlockPixel);
			g += (byte)((float)colors[i].g / (float)numOfBlockPixel);
			b += (byte)((float)colors[i].b / (float)numOfBlockPixel);
			a += (byte)((float)colors[i].a / (float)numOfBlockPixel);
		}
		return new Color32(r,g,b,a);
	}
}
