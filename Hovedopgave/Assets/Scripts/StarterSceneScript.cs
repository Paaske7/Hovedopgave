using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class StarterSceneScript : MonoBehaviour {
    // Mikaal Paaske

    private MenuChanger menuChanger;

    public Image splashImage;

    void Awake()
    {
        menuChanger = GetComponent<MenuChanger>();
    }     
    IEnumerator Start() // En klasse der kaldes coroutine der ligger i .Net der hjælper med at stoppe processor.
    {
      splashImage.canvasRenderer.SetAlpha(0.0f);

        FadeIn();
        yield return new WaitForSeconds(3.5f); // Venter 3.5 sekunder
        FadeOut();
        yield return new WaitForSeconds(2.0f); // Venter 2.0 sekunder
        menuChanger.changemenusceneMainMenu(); // Skifter til hovedmenu scenen
    }
    void FadeIn()
    {
        // skifter alpha på vores splashimage
        splashImage.CrossFadeAlpha(1.0f, 2.5f, false);
    }
    void FadeOut()
    {
        // skifter alpha på vores splashimage
        splashImage.CrossFadeAlpha(0.0f, 2.5f, false);

    }
    
	
	
}
