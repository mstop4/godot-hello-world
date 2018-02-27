using Godot;
using System;

public class HelloWorld : Node
{
    private int counter;

    public override void _Ready()
    {
        counter = 0;
        GetNode("Button").Connect("pressed", this, nameof(_OnButtonPressed));
    }

    public void _OnButtonPressed() {
        counter++;
        GD.Print("Poke " + counter);
    }
}
