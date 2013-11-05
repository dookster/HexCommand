using UnityEngine;
using System.Collections;

public class HexBlock : MonoBehaviour {
	
	
	private double sixth = 1f/6f;
	
	/*      
	 *       5   Top
	 *   4  ___  0 
	 *     /   \  
	 *     \___/ 
	 *   3       1
	 *       2
	 * 
	 */      
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnMouseOver() {
		if(Input.GetMouseButtonUp(0)){
			if(iTween.Count(gameObject) == 0)
				turn();
		}        
    }
	
	private void turn(){
		float delay = 0.5f;
		float height = 0.2f;
		iTween.MoveBy(gameObject,iTween.Hash("z",height,"time",delay,"easetype","easeinoutexpo"));
		iTween.RotateBy(gameObject,iTween.Hash("z",sixth,"time",delay,"easetype","easeinback","delay",delay));
		iTween.MoveBy(gameObject,iTween.Hash("z",-height,"time",delay*2,"easetype","easeinoutexpo", "delay", delay*2));
	}
	
	
}
