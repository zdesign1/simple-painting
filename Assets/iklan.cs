using UnityEngine;
using System.Collections;
using GoogleMobileAds.Api;

public class iklan : MonoBehaviour {
    private BannerView bannerView;

  void Start () 
  {
    RequestBanner ();
  }

  // Update is called once per frame
  
  // Back to Main Menu

  // AdMob Advertisement
  private void RequestBanner()
  {
    string adUnitId = "ca-app-pub-4697579006360442/5518347117";

    // Create a 320x50 banner at the top of the screen.
    BannerView bannerView = new BannerView(adUnitId, AdSize.Banner, AdPosition.Bottom);
    // Create an empty ad request.
    AdRequest request = new AdRequest.Builder().Build();
    // Load the banner with the request.
    bannerView.LoadAd(request);
  }
}