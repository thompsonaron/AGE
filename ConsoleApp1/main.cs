using System;

namespace ConsoleApp1
{
    class main
    {
        static void Main(string[] args)
        {
            TheGame theGame = new TheGame();
            theGame.Setup();
        }
    }

    class TheGame
    {
        AGE age = new AGE();

        // TOP WALL
        GameObject wall0 = new GameObject(0, 0, 'X');
        GameObject wall1 = new GameObject(1, 0, 'X');
        GameObject wall2 = new GameObject(2, 0, 'X');
        GameObject wall3 = new GameObject(3, 0, 'X');
        GameObject wall4 = new GameObject(4, 0, 'X');
        GameObject wall5 = new GameObject(5, 0, 'X');
        GameObject wall6 = new GameObject(6, 0, 'X');
        GameObject wall7 = new GameObject(7, 0, 'X');
        GameObject wall8 = new GameObject(8, 0, 'X');
        GameObject wall9 = new GameObject(9, 0, 'X');

        // SIDE WALLS
        GameObject wall10 = new GameObject(0, 1, 'X');
        GameObject wall11 = new GameObject(9, 1, 'X');
        GameObject wall12 = new GameObject(0, 2, 'X');
        GameObject wall13 = new GameObject(9, 2, 'X');
        GameObject wall14 = new GameObject(0, 3, 'X');
        GameObject wall15 = new GameObject(9, 3, 'X');
        GameObject wall16 = new GameObject(0, 4, 'X');
        GameObject wall17 = new GameObject(9, 4, 'X');
        GameObject wall18 = new GameObject(0, 5, 'X');
        GameObject wall19 = new GameObject(9, 5, 'X');
        GameObject wall20 = new GameObject(0, 6, 'X');
        GameObject wall21 = new GameObject(9, 6, 'X');
        GameObject wall22 = new GameObject(0, 7, 'X');
        GameObject wall23 = new GameObject(9, 7, 'X');
        GameObject wall24 = new GameObject(0, 8, 'X');
        GameObject wall25 = new GameObject(9, 8, 'X');
        GameObject wall26 = new GameObject(0, 9, 'X');
        GameObject wall27 = new GameObject(9, 9, 'X');

        // BOTTOM WALL
        GameObject wall30 = new GameObject(0, 10, 'X');
        GameObject wall31 = new GameObject(1, 10, 'X');
        GameObject wall32 = new GameObject(2, 10, 'X');
        GameObject wall33 = new GameObject(3, 10, 'X');
        GameObject wall34 = new GameObject(4, 10, 'X');
        GameObject wall35 = new GameObject(5, 10, 'X');
        GameObject wall36 = new GameObject(6, 10, 'X');
        GameObject wall37 = new GameObject(7, 10, 'X');
        GameObject wall38 = new GameObject(8, 10, 'X');
        GameObject wall39 = new GameObject(9, 10, 'X');

        // PLAYER AND GOAL
        GameObject player = new GameObject(2, 2, 'P');
        GameObject goal = new GameObject(7, 7, 'G');
        private bool win;


        GameObject y = new GameObject(0, 11, 'Y');
        GameObject u = new GameObject(1, 11, 'o');
        GameObject o = new GameObject(2, 11, 'u');
        GameObject W = new GameObject(4, 11, 'W');
        GameObject i = new GameObject(5, 11, 'i');
        GameObject n = new GameObject(6, 11, 'n');
        GameObject I = new GameObject(7, 11, '!');

        public void Setup()
        {
            age.gameObjects.Add(wall0);
            age.gameObjects.Add(wall1);
            age.gameObjects.Add(wall2);
            age.gameObjects.Add(wall3);
            age.gameObjects.Add(wall4);
            age.gameObjects.Add(wall5);
            age.gameObjects.Add(wall6);
            age.gameObjects.Add(wall7);
            age.gameObjects.Add(wall8);
            age.gameObjects.Add(wall9);

            age.gameObjects.Add(wall10);
            age.gameObjects.Add(wall11);
            age.gameObjects.Add(wall12);
            age.gameObjects.Add(wall13);
            age.gameObjects.Add(wall14);
            age.gameObjects.Add(wall15);
            age.gameObjects.Add(wall16);
            age.gameObjects.Add(wall17);
            age.gameObjects.Add(wall18);
            age.gameObjects.Add(wall19);
            age.gameObjects.Add(wall20);
            age.gameObjects.Add(wall21);
            age.gameObjects.Add(wall22);
            age.gameObjects.Add(wall23);
            age.gameObjects.Add(wall24);
            age.gameObjects.Add(wall25);
            age.gameObjects.Add(wall26);
            age.gameObjects.Add(wall27);

            age.gameObjects.Add(wall30);
            age.gameObjects.Add(wall31);
            age.gameObjects.Add(wall32);
            age.gameObjects.Add(wall33);
            age.gameObjects.Add(wall34);
            age.gameObjects.Add(wall35);
            age.gameObjects.Add(wall36);
            age.gameObjects.Add(wall37);
            age.gameObjects.Add(wall38);
            age.gameObjects.Add(wall39);

            age.gameObjects.Add(player);
            age.gameObjects.Add(goal);



            age.gameplayUpdate = UpdateLoop;
            age.init();
        }

        public void UpdateLoop()
        {
            if (win)
                return;


            if (age.w.down && player.position.y > 0)
            {
                player.position = new GameObject.Vector2(player.position.x, player.position.y - 1);
            }
            if (age.a.down && player.position.x > 0)
            {
                player.position = new GameObject.Vector2(player.position.x - 1, player.position.y);
            }
            if (age.s.down && player.position.y < 15)
            {
                player.position = new GameObject.Vector2(player.position.x, player.position.y + 1);
            }
            if (age.d.down && player.position.x < 15)
            {
                player.position = new GameObject.Vector2(player.position.x + 1, player.position.y);
            }

            if (player.position.x == goal.position.x && player.position.y == goal.position.y)
            {
                win = true;
                age.gameObjects.Add(y);
                age.gameObjects.Add(o);
                age.gameObjects.Add(u);
                age.gameObjects.Add(W);
                age.gameObjects.Add(i);
                age.gameObjects.Add(n);
                age.gameObjects.Add(I);
            }
        }
    }
}
