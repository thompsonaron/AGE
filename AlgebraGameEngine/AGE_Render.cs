using System;

public partial class AGE
{
    char[][] consoleScreen;
    public int displayWidth = 30;
    public int displayHeight = 30;

    // renderSetup has to run before render
    public void render()
    {
        // "clear" screen
        for (int i = 0; i < displayHeight; i++)
        {
            for (int j = 0; j < displayWidth; j++)
            {
                consoleScreen[i][j] = ' ';
            }
        }

        // object input
        for (int i = 0; i < gameObjects.Count; i++)
        {
            consoleScreen[gameObjects[i].position.x][gameObjects[i].position.y] = gameObjects[i].charRenderer;
        }

        for (int i = 0; i < 30; i++)
        {
            for (int j = 0; j < 30; j++)
            {
                Console.SetCursorPosition(i, j);
                Console.Write(consoleScreen[i][j]);
            }
        }
    }

    public void renderSetup()
    {
        consoleScreen = new char[displayHeight][];
        for (int i = 0; i < displayHeight; i++)
        {
            consoleScreen[i] = new char[30];         
        }
    }
}
