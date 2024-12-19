using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public enum EPlayerColor
{
    Red, Blue, Green,
    Pink, Orange, Yellow,
    Black, White, Purple,
    Brown, Cyan, Lime
}

public class PlayerColor
{
    private static List<Color> colors = new List<Color>()
    {
        new Color(1f, 0f, 0f),    // Red
        new Color(0f, 0f, 1f),    // Blue
        new Color(0f, 1f, 0f),    // Green
        new Color(1f, 0f, 1f),    // Pink
        new Color(1f, 0.647f, 0f), // Orange
        new Color(1f, 1f, 0f),    // Yellow
        new Color(0f, 0f, 0f),    // Black
        new Color(1f, 1f, 1f),    // White
        new Color(0.5f, 0f, 0.5f), // Purple
        new Color(0.6f, 0.3f, 0f), // Brown
        new Color(0f, 1f, 1f),    // Cyan
        new Color(0.196f, 0.804f, 0.196f) // Lime
    };

    public static Color GetColor(EPlayerColor playerColor)
    {
        return colors[(int)playerColor];
    }

    // Getters for each color
    public static Color Red
    {
        get { return colors[(int)EPlayerColor.Red]; }
    }

    public static Color Blue
    {
        get { return colors[(int)EPlayerColor.Blue]; }
    }

    public static Color Green
    {
        get { return colors[(int)EPlayerColor.Green]; }
    }

    public static Color Pink
    {
        get { return colors[(int)EPlayerColor.Pink]; }
    }

    public static Color Orange
    {
        get { return colors[(int)EPlayerColor.Orange]; }
    }

    public static Color Yellow
    {
        get { return colors[(int)EPlayerColor.Yellow]; }
    }

    public static Color Black
    {
        get { return colors[(int)EPlayerColor.Black]; }
    }

    public static Color White
    {
        get { return colors[(int)EPlayerColor.White]; }
    }

    public static Color Purple
    {
        get { return colors[(int)EPlayerColor.Purple]; }
    }

    public static Color Brown
    {
        get { return colors[(int)EPlayerColor.Brown]; }
    }

    public static Color Cyan
    {
        get { return colors[(int)EPlayerColor.Cyan]; }
    }

    public static Color Lime
    {
        get { return colors[(int)EPlayerColor.Lime]; }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
