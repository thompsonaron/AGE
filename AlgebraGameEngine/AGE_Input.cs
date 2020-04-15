using System;
using System.Runtime.InteropServices;

public partial class AGE
{
	public KeyState w = new KeyState() { keyCode = 0x57 };
	public KeyState a = new KeyState() { keyCode = 0x41 };
	public KeyState s = new KeyState() { keyCode = 0x53 };
	public KeyState d = new KeyState() { keyCode = 0x44 };

	[DllImport("user32.dll")]
	static extern ushort GetAsyncKeyState(int vKey);

	public void inputUpdate()
	{
		updateKeyState(w);
		updateKeyState(a);
		updateKeyState(s);
		updateKeyState(d);

		void updateKeyState(KeyState k)
		{
			bool isPressed = GetAsyncKeyState(k.keyCode) > 0;
			if (isPressed)
			{
				if (!k.down && !k.hold)
				{
					k.down = true;
				}
				else if (k.down)
				{
					k.down = false;
					k.hold = true;
				}
			}
			else
			{
				if (k.hold)
				{
					k.hold = false;
					k.up = true;
				}
				else
				{
					k.up = false;
				}
			}
		}
	}
}

public class KeyState
{
	public int keyCode;
	public bool down;
	public bool hold;
	public bool up;
}