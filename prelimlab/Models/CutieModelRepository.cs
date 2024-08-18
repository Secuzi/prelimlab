using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace prelimlab.Models
{
	public static class CutieModelRepository
	{
		const string filePath = "Resources/Images";

		static List<CutieModel> _cutieModels = new List<CutieModel>()
		{
			new()
			{
				CutieId = 1,
				Title = "Puppy Love",
				User = "doglover123",
				Description = "Meet Bella, the fluffiest puppy! Her playful spirit and wagging tail bring joy to everyone around her. Just look at those big, soulful eyes!",
				Image = new() { Source = ImageSource.FromFile(Path.Combine(filePath, "dog1.jpg")), Aspect = Aspect.AspectFill}
			},
			new()
			{
				CutieId = 2,
				Title = "Cutie Patootie",
				User = "anotherdog",
				Description = "Meet Bella, the fluffiest puppy! Her playful spirit and wagging tail bring joy to everyone around her. Just look at those big, soulful eyes!",
				Image = new() { Source = ImageSource.FromFile(Path.Combine(filePath, "dog1.jpg")), Aspect = Aspect.AspectFill}
			},


		};

		public static List<CutieModel> GetCuties() => _cutieModels;




	}
}
