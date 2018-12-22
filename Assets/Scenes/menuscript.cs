using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuscript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		// Create raycast
		RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

		if (Input.GetMouseButtonDown(0)) {
			if (hit.collider != null) {
				if (hit.collider.gameObject.name == "playbutton") {
					SceneManager.LoadScene("SampleScene");
				}

				if (hit.collider.gameObject.name == "tutorialbutton") {
					SceneManager.LoadScene("Tutorial");
				}
			}
		}
	}
}
