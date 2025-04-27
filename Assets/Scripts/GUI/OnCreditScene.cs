using UnityEngine;

public class OnCreditScene : MonoBehaviour
{
public void ToCreditScene(){
if (GameManager.instance != null){
    GameManager.instance.ActivateCreditScene();
}
}
}