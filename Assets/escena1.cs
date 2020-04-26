using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class escena1 : MonoBehaviour
{
	public void cambiarescena1(string nombreescena)
	{
		SceneManager.LoadScene(1);
	}
	public void cambiarescena2(string nombreescena)
	{
		SceneManager.LoadScene(2);
	}
	public void cambiarescena3(string nombreescena)
	{
		SceneManager.LoadScene(3);
	}
	public void cambiarescena4(string nombreescena)
	{
		SceneManager.LoadScene(4);
	}
}
