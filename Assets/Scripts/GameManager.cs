using UnityEngine;
using UnityEditor;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public GameObject StartMenu;
    public GameObject MainMenu;
    public GameObject SettingsMenu;
    public GameObject CreditScene;
    public GameObject GamePlay;


    public void Awake(){
        if(instance == null){
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else{
            Destroy(gameObject);
        }
    }
    void Start()
    {
        ActivateStartMenu();
    }

    // Update is called once per frame
    void Update()
    {
    }


        public void DeactivateAllStates(){
            StartMenu.SetActive(false);
            MainMenu.SetActive(false);
            SettingsMenu.SetActive(false);
            CreditScene.SetActive(false);
            GamePlay.SetActive(false);
        }
        public void ActivateStartMenu(){
            DeactivateAllStates();
            StartMenu.SetActive(true);
        }
        public void ActivateMainMenu(){
            DeactivateAllStates();
            MainMenu.SetActive(true);
        }
        public void ActivateSettingsMenu(){
            DeactivateAllStates();
            SettingsMenu.SetActive(true);
        }
        public void ActivateCreditScene(){
            DeactivateAllStates();
            CreditScene.SetActive(true);
        }
        public void ActivateGamePlay(){
            DeactivateAllStates();
            GamePlay.SetActive(true);
        }
        public void QuitGame(){
           EditorApplication.ExitPlaymode();
            Application.Quit();
        }

    }


