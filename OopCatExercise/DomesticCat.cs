using System;
namespace OopCatExercise
{

	public class DomesticCat : Cat
		{

			public DomesticCat () : base (averageHeight : 23, setting: "domestic")
			{
			}

		public override string Eat() => "Purrrrrrr";
	}
	
}

