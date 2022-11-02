using System;
using Godot;

public class PrintDate : Node
{
    public override void _Ready()
    {
        var date = DateTime.Now;
        GD.Print($"{date}");
    }
}
