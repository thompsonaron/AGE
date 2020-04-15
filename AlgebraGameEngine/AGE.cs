using System;
using System.Collections.Generic;


public partial class AGE
{
	public delegate void GameplayUpdate();
	public GameplayUpdate gameplayUpdate;

	public List<GameObject> gameObjects = new List<GameObject>();

	public void init()
	{
		Console.CursorVisible = false;
		renderSetup();
		while (true)
		{
			inputUpdate();
			//do gameplay loop
			gameplayUpdate?.Invoke();
			render();
		}
	}

}

public class GameObject
{
	public Vector2 position;
	public char charRenderer;

	public GameObject(int x, int y, char charRender)
	{
		position = new Vector2(x, y);
		charRenderer = charRender;
	}

	public class Vector2
	{
		public int x;
		public int y;

		public Vector2(int _x, int _y)
		{
			x = _x;
			y = _y;
		}
	}
}