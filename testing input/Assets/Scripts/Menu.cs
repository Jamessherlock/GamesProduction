using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    [SerializeField]
    private Button play;



    // Start is called before the first frame update
    void Start()
    {

        play.onClick.AddListener(LoadScene);



    }

    private void LoadScene() {
        SceneManager.LoadScene("Game");
    }


}
