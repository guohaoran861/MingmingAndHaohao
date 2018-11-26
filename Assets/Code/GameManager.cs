using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
	AllViewGet allViewGet;

	void Start () {
		allViewGet = gameObject.GetComponent<AllViewGet>();
	}
	
	public void OnClickSetting()
	{
		
	}

	public void OnSliderScrool()
	{
		//Debug.Log(allViewGet.Slider.value);
	}

	void Update () {
		
	}
}