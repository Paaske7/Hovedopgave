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
        yield return new WaitForSeconds(3.5f); // Suspends the coroutine execution for the given amount of seconds using scaled time.
        FadeOut();
        yield return new WaitForSeconds(2.0f);
        menuChanger.changemenusceneMainMenu();
    }
    void FadeIn()
    {
        splashImage.CrossFadeAlpha(1.0f, 2.5f, false);
    }
    void FadeOut()
    {
        splashImage.CrossFadeAlpha(0.0f, 2.5f, false);

    }
    
	
	
}
