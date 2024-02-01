//Final solution after refactoring and after consulting best solutions from other players

string[] inputs = Console.ReadLine().Split(' ');
int lx = int.Parse(inputs[0]); // the X position of the light of power
int ly = int.Parse(inputs[1]); // the Y position of the light of power
int tx = int.Parse(inputs[2]); // Thor's starting X position
int ty = int.Parse(inputs[3]); // Thor's starting Y position


// game loop

int remainingTurns = int.Parse(Console.ReadLine()); // The remaining amount of turns Thor can move. Do not remove this line.

while (true)
{

    var y = "";
    var x = "";
    if(tx>lx){ x="W";tx--;}
    if(tx<lx){ x="E";tx++;}    
    if(ty>ly){ y="N";ty--;}
    if(ty<ly){ y="S";ty++;}
    Console.WriteLine($"{y}{x}");

}