using UnityEngine;

public enum MaterialType { NoMaterial, Earth, Grass, Sticky };

public class Material
{
    public Color color;
    public uint density;

    protected MaterialType type;


    public Material ()
    {
        type = MaterialType.NoMaterial;
        color = Color.black;
        density = 9999999;
    }
}

public class Earth : Material
{
    public Earth()
    {
        type = MaterialType.Earth;
        color = new Color(.55f, .3f, .1f);
        density = 100;
    }
}

public class Grass : Material
{
    public Grass()
    {
        type = MaterialType.Sticky;
        color = new Color(0, .5f, 0);
        density = 5;
    }
}

public class Sticky : Material
{
    public Sticky()
    {
        type = MaterialType.Sticky;
        color = new Color(.8f, .8f, 0);
        density = 20;
    }
}