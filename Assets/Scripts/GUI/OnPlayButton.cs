using UnityEngine;

public class OnPlayButton : MonoBehaviour
{
public void ToGamePlay(){
if (GameManager.instance != null){
    GameManager.instance.ActivateGamePlay();
}
}
}

