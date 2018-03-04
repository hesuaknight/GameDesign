using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject credits;
    public GameObject skillInfo;
    public AudioSource click;

	// Use this for initialization
	void Start ()
    {
        credits.gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Credits()
    {
        click.Play();
        credits.gameObject.SetActive(true);
    }

    public void Back()
    {
        click.Play();
        credits.gameObject.SetActive(false);
    }

    public void StartGame()
    {
        StartCoroutine(NewGame());
    }

    private IEnumerator NewGame()
    {
        click.Play();
        skillInfo.SetActive(true);

        yield return new WaitForSeconds(12);
        SceneManager.LoadSceneAsync(1);        
    }
}
