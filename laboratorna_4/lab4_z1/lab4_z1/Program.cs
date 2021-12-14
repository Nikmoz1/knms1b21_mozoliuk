using System;
using System.Collections.Generic;

public class Continent
{
	private string name;

	public Continent(string name)
	{
		this.name = name;
	}

	public virtual string Name
	{
		get
		{
			return name;
		}
	}
}
public class Island
{
	private string name;

	public Island(string name)
	{
		this.name = name;
	}

	public virtual string Name
	{
		get
		{
			return name;
		}
	}
}
public class Ocean
{
	private string name;

	public Ocean(string name)
	{
		this.name = name;
	}

	public virtual string Name
	{
		get
		{
			return name;
		}
	}
}
public class Planet
{
	private string name;

	private IList<Ocean> oceanList = new List<Ocean>();
	private IList<Continent> continentList = new List<Continent>();
	private IList<Island> islandList = new List<Island>();

	public Planet(string name)
	{
		this.name = name;
	}

	public virtual void addOcean(Ocean ocean)
	{
		oceanList.Add(ocean);
	}

	public virtual void addContinent(Continent continent)
	{
		continentList.Add(continent);
	}

	public virtual void addIsland(Island island)
	{
		islandList.Add(island);
	}

	public virtual string Name
	{
		get
		{
			return name;
		}
	}

	public virtual IList<Ocean> OceanList
	{
		get
		{
			return oceanList;
		}
	}

	public virtual IList<Continent> ContinentList
	{
		get
		{
			return continentList;
		}
	}

	public virtual IList<Island> IslandList
	{
		get
		{
			return islandList;
		}
	}
}
class PlanetRunner
{
	static void Main(string[] args)
	{
		Island island = new Island("Barbados");

		Planet planet = new Planet("Earth");

		planet.addContinent(new Continent("Eurasia"));
		planet.addContinent(new Continent("Africa"));

		planet.addOcean(new Ocean("Atlantic"));
		planet.addOcean(new Ocean("Pacific"));

		planet.addIsland(new Island("Barbados"));

		Console.WriteLine("Planet name: " + planet.Name);
		Console.WriteLine("Continent name: " + getFirstContinentName(planet.ContinentList));
		Console.WriteLine("Count continents:" + planet.ContinentList.Count);
	}

	public static string getFirstContinentName(IList<Continent> continentList)
	{
		string result = null;
		foreach (Continent continent in continentList)
		{
			result = continent.Name;
		}

		return result;
	}
}