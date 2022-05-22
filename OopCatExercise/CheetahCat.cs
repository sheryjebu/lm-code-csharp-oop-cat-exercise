using System;
namespace OopCatExercise
{
	public class CheetahCat : Cat
    {
        public CheetahCat() : base(averageHeight: 1500, setting: "wild")
        {

        }
        public override string Eat()
        {
            return "Zzzzzzz";
        }
    }
}

