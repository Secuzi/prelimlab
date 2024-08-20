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
				Image = new() { Source = ImageSource.FromFile(Path.Combine(filePath, "hedgehog.jpg")), Aspect = Aspect.AspectFill}
			},
			new()
			{
				CutieId = 3,
				Title = "Cutie Regie",
				User = "anotherdog",
				Description = "Meet Regie, the fluffiest seal! Her playful spirit and wagging tail bring joy to everyone around her. Just look at those big, soulful eyes!",
				Image = new() { Source = ImageSource.FromFile(Path.Combine(filePath, "babyseal.jpg")), Aspect = Aspect.AspectFill}
			},
			new()
			{
				CutieId = 4,
				Title = "Cutie Maemae",
				User = "anotherdog",
				Description = "Meet Maemae, the fluffiest puppy! Her playful spirit and wagging tail bring joy to everyone around her. Just look at those big, soulful eyes!",
				Image = new() { Source = ImageSource.FromFile(Path.Combine(filePath, "catpic.jpg")), Aspect = Aspect.AspectFill}
			},
			new()
			{
				CutieId = 5,
				Title = "Cutie Maemae",
				User = "anotherdog",
				Description = "Meet Maemae, the fluffiest puppy! Her playful spirit and wagging tail bring joy to everyone around her. Just look at those big, soulful eyes!",
				Image = new() { Source = ImageSource.FromFile(Path.Combine(filePath, "catpic1.jpg")), Aspect = Aspect.AspectFill}
			},
			new()
			{
				CutieId = 6,
				Title = "Cutie Maemae",
				User = "secuzi",
				Description = "Meet Maemae, the cutest perzon! Her playful spirit bring joy to everyone around her. Just look at those big, soulful eyes!",
				Image = new() { Source = ImageSource.FromFile(Path.Combine(filePath, "regine.jpg")), Aspect = Aspect.AspectFill}
			},
		};

		public static List<CutieModel> GetCuties() => _cutieModels;




	}
}
