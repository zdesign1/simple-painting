using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound : MonoBehaviour {

private SpriteS s_sprite;

private bool s_on;

private void Start()
{
	s_sprite = GetComponent<SpriteS>();
	s_on = PlayerPrefs.GetInt("sound_on") == 1;
	if (!s_on)
		s_sprite.SwapSprite();
}

public void Toggle()
{
	s_on = !s_on;
	AudioListener.volume = s_on ? 1 : 0;
	PlayerPrefs.SetInt("sound_on", s_on ? 1 : 0);
}

public void ToggleSprite()
{
	s_on = !s_on;
	s_sprite.SwapSprite();
}
}	
