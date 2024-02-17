using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class playMusic : MonoBehaviour
{
	public AudioSource audio;
	public bool pressed;
	private Image img;

    // Start is called before the first frame update
    void Start()
    {
        pressed = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	public void play()
	{
		if(!pressed){
			pressed = true;
			audio.Play();
			
		}
		else{
			pressed = false;
			audio.Stop();
			img = GameObject.Find("BeatTint").GetComponent<Image>();
			img.color =  new Color(0, 0, 0,0);
		}
		
	}
}
