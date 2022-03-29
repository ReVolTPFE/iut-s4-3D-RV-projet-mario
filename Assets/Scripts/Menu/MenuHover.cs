using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuHover : MonoBehaviour
{
	public Text text;
	void Start()
	{
        //SceneManager.LoadScene("menu");

        text = gameObject.GetComponent<Text>();
		text.color = Color.black;
	}

    void OnMouseEnter()
    {
        text.color = Color.blue;
    }

	void OnMouseExit()
	{
		text.color = Color.black;
	}
}
