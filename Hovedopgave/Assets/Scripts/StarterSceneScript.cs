using UnityEngine;

public class StarterSceneScript : MonoBehaviour {
    // Mikaal Paaske

    private MenuChanger menuChanger2;
    private float delayBeforeLoading = 5f;
    private float timeElapsed;

    void Awake()
    {
        menuChanger2 = GetComponent<MenuChanger>();
    }
    void Update () {

        timeElapsed += Time.deltaTime;

        if (timeElapsed > delayBeforeLoading)
        {
            menuChanger2.changemenusceneMainMenu();
        }
       
	}
	
	
}
