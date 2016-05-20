using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

	public Text text;
	// Use this for initialization
	void Start () {
		text.text = "Hello World!";
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Space)) {
			text.text = "It's been 34 days since the incident, seven million dollars " + 
				"embezzled and every trace of evidence points back to you. Your know" +
				"you're incident, but you have no proof. Your fingerprints were on the " +
				"keyboard on the computer that the money was stolen on. You need to escape " +
				"from prison, investigate the scene on your own and gather evidence, and break " +
				"back into prison before dawn. You're the only hope for your family. "+
				"All you have in your cell are some dirty sheets, a file, and the barred door" +
				"seems to be locked from the outside.\n\nPress S to view the sheets, F to" + 
				"view the file, and D to view the door.";
		}
	}
} 