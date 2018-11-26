using UnityEngine;
using UnityEngine.UI;

public class AllViewGet :MonoBehaviour {
	private Slider _slider;
	public Slider Slider
	{
		get
		{
			if (_slider == null)
			{
				_slider = GameObject.Find("RootCanvas/PanelBg/UI/Slider").GetComponent<Slider>();
			}
			return _slider;
		}
	}
}
