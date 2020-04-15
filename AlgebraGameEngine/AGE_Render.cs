using System;

public partial class AGE
{
    char[][] consoleScreen;
    char[][] clearScreen;
    public int displayWidth = 30;
    public int displayHeight = 30;

    // renderSetup has to run before render
    public void render()
    {
        renderSetup();
        consoleScreen = (char[][])clearScreen.Clone();

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
        clearScreen = new char[displayHeight][];
        for (int i = 0; i < displayHeight; i++)
        {
            clearScreen[i] = new char[30];
            for (int j = 0; j < displayWidth; j++)
            {
                clearScreen[i][j] = ' ';
            }
        }
    }
}
