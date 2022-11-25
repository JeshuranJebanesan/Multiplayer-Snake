using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
	[SerializeField] private Menu[] menus;
	private static MenuManager instance;

    private void Awake()
    {
		instance = this;
    }

    public void OpenMenu(Menu menu)
	{
		for (int i = 0; i < menus.Length; i++)
		{
			if (menus[i].GetOpen())
			{
				menus[i].Close();
			}
		}
		menu.Open();
	}
}