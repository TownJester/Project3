using UnityEngine;

public class OnQuit : MonoBehaviour
{
public void ExitGame(){
if (GameManager.instance != null){
    GameManager.instance.QuitGame();
}
}
}
