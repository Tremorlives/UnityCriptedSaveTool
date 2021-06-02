# UnityCriptedSaveTool

To use this plugin create a class witch will store all the data (only variables , no functions)
ex:

public class PlayerStats
{
   public int lives;
   public string name;
   public float fortunestat;
}

Then in a different script write " using SaveToolKit " in the first line

And it's done you've setted up the tool!

Now create a public istance of the class and give give set the variables up

public class MyFirstSaveProgram
{
    public PlayerStats pl = new PlayerStats();
    pl.lives = 4;
    pl.name = "John Cena"
    pl.fortunestat = 0
}

The funcions are :
SaveTool.Save(string file , object tosave) : 
use this function to save in a file , you need to give this function the file name and if there are no packages with that name this function is going to create a file with that name.
ex:

using SaveToolKit;
public class MyFirstSaveProgram
{
    public PlayerStats pl = new PlayerStats();
    pl.lives = 4;
    pl.name = "John Cena"
    pl.fortunestat = 0
    public string filename = "IloveBananas.txt"
    SaveTool.Save(filename, pl);
}

SaveTool.Load(string file , object toload)  :
use this function to override data from the file you saved data on

ex:

using SaveToolKit;
public class MyFirstSaveProgram
{
    public PlayerStats pl = new PlayerStats();
    pl.lives = 4;
    pl.name = "John Cena";
    pl.fortunestat = 0;
    SaveTool.Save("IloveBananas.txt, pl);
    pl.lives = 50;
    pl.name = "Lollypop"
    pl.fortunestat = 23
    SaveTool.Load("IloveBananas.txt, pl);
    Debug.Log(pl.lives)
}

Output: 4




HOPE YOU CAN ENJOY THIS TOOL

DISCLAMER:
i'm not a professional develper so this isn't perfect code and it can be improved a lot so thnks for ur patience
