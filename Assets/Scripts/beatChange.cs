using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class beatChange : MonoBehaviour
{
	private Image img;
	public List<Color> colorList;
    // Start is called before the first frame update
    void Start()
    {
		img = GameObject.Find("BeatTint").GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	public void Change()
	{
		img.color = GetRandomColor();
		if(FindObjectOfType<shooting>() != null){
			FindObjectOfType<shooting>().shoot();
		}
		
	}

	Color GetRandomColor(){
        return colorList[Random.Range (0, 9)];
    }
}
