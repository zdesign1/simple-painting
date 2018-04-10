using System.Collections;
using UnityEngine;

public class responsif : MonoBehaviour {

	public ScaleType tipeSkala = ScaleType.ASPECT_RATIO;
	public ResponsiveMode responsifM = ResponsiveMode.AWAKE;
	public float xscalefraction = 0.1f;
	public float yscalefraction = 0.1f;
	public float xposfraction = 0.5f;
	public float yposfraction = 0.5f;
	public float aspectfrac = 1;
	public bool doScale = true;
	public bool doTranslate = true;
	public bool isEnabled = true;
	public Camera kamera;

void Awake ()
		{
				if (kamera == null) {
						kamera = Camera.main;
				}
		
				if (isEnabled) {
						if (responsifM == ResponsiveMode.AWAKE) {
								atPosisidanSkala ();
						}
				}
		}
void update ()
	{
		if (isEnabled){
			if (responsifM == ResponsiveMode.UPDATE)
			atPosisidanSkala ();
		}
	}
private void atPosisidanSkala (){
if (doTranslate){
		PercentagePositioning ();
	}
	if (doScale) {
		if (tipeSkala == ScaleType.ASPECT_RATIO){
		AspectRatioScaling ();
		} else if (tipeSkala == ScaleType.PERCENTAGE){
		PercentageScaling ();
}
	}
}

private void PercentagePositioning (){
	int lwidth = Screen.width;
	int lheight = Screen.height;
	Vector3 positionwolrldvector = kamera.ScreenToWorldPoint (new Vector2 (lwidth * xposfraction, lheight * yposfraction));
	transform.position = new Vector3 (positionwolrldvector.x, positionwolrldvector.y, transform.position.z);
}

private void PercentageScaling ()
{
	int lwidth = Screen.width;
	int lheight = Screen.height;
	Vector3 sscalewolrldvector = kamera.ScreenToWorldPoint (new Vector2 (lwidth, lheight));
	transform.localScale = new Vector3 (sscalewolrldvector.x * xscalefraction, sscalewolrldvector.y * yscalefraction, transform.localScale.z);
}

private void AspectRatioScaling ()
{
float aspectRatio = kamera.aspect;
transform.localScale = new Vector3 (aspectRatio * aspectfrac, aspectRatio * aspectfrac, aspectRatio * aspectfrac);
}


public enum ScaleType
{
	PERCENTAGE,
	ASPECT_RATIO
}

public enum ResponsiveMode
{
	AWAKE,
	UPDATE
	}
}
