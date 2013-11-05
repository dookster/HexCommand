using UnityEngine;
using System.Collections;

public class GameFlow : MonoBehaviour {
	
	public Transform hexPrefab;
	public int width;
	public int height;
	
	private Bounds hexBounds;
	private float hexWidth;
	private float hexHeight;
	
	// Use this for initialization
	void Start () {
		Mesh messh = hexPrefab.GetComponent<MeshFilter>().sharedMesh;
		hexWidth = messh.bounds.size.x;
		hexHeight = messh.bounds.size.y;
		spawnBlocks();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	private void spawnBlocks(){
		for(int x = 0 ; x < width ; x++){
			for(int y = 0 ; y < height ; y++){
				float tileHeight = Random.Range(0,3) * 0.2f;
				Instantiate(hexPrefab, new Vector3(transform.position.x + (hexWidth * x) + (y%2 == 0 ? 0 : hexWidth / 2), transform.position.y + tileHeight, transform.position.z + (hexHeight * 0.75f * y)), transform.rotation);
			}
		}
	}
	
}
