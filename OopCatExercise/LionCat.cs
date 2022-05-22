using System;
namespace OopCatExercise
{
	public class LionCat : Cat
    {
        public LionCat() : base(averageHeight: 1100, setting: "wild")
        {

        }
        public override string Eat()
        {
            return "Roar!!!!";
        }
    }
}

