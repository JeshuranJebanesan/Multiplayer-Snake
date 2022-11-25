using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
#pragma warning disable 0649
	[SerializeField] private bool open;
#pragma warning restore 0649

	public void Open()
	{
		open = true;
		gameObject.SetActive(true);
	}

	public void Close()
	{
		open = false;
		gameObject.SetActive(false);
	}
 
	public bool GetOpen()
    {
		return open;
    }
}