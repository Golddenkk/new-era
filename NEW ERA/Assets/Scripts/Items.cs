using UnityEngine;
using System.Collections;

interface Item
{
	int GetPrice();
}

public class Wood : Item {
	public int GetPrice() 
	{
		return 247;
	}
	public override string ToString ()
	{
		return string.Format ("[Wood]");
	}
}

public class Brick : Item {
	public int GetPrice()
	{
		return 647;
	}
	public override string ToString ()
	{
		return string.Format ("[Brick]");
	}
}

public class Beer : Item {
	public int GetPrice() 
	{
		return 724;
	}
	public override string ToString ()
	{
		return string.Format ("[Beer]");
	}
}
