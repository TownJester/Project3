using UnityEngine;

public class OnSettings : MonoBehaviour
{
public void ChangeToSettings(){
if (GameManager.instance != null){
    GameManager.instance.ActivateSettingsMenu();
}
}
}
