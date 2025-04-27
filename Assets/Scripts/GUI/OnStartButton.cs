using UnityEngine;

public class OnStartButton : MonoBehaviour
{

public void ToMainMenu(){
if (GameManager.instance != null){
    GameManager.instance.ActivateMainMenu();
}
}
}