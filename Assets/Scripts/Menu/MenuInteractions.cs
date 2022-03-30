using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInteractions : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.name == "Jouer")
                {
                    SceneManager.LoadScene("chateau");
                }
                if (hit.transform.name == "Quitter")
                {
                    Application.Quit();
                }

                if (hit.transform.name == "Lvl1")
                {
                    SceneManager.LoadScene("chateau");
                }
                if (hit.transform.name == "Lvl2")
                {
                    SceneManager.LoadScene("neige");
                }
                if (hit.transform.name == "Lvl3")
                {
                    SceneManager.LoadScene("Undertale");
                }
            }
        }
    }
}
