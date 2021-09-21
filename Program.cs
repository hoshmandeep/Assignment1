using System;
using System.Collections.Generic;
using System.Linq;

namespace assignment_1


{
	public class Program
	{
		static void Main(string[] args)
		{

		

			Console.WriteLine("Enter the number of cards to pick: ");
			string line = Console.ReadLine();
			if (int.TryParse(line, out int numCards))
			{
				foreach (var card in CardPicker.PickSomeCards(numCards))
				{
					Console.WriteLine(card);
				}
			}
			else
			{
				Console.WriteLine("Please enter a valid number.");
			}


			//subsequence if match then return true otherwise false.
			var list_1 = new List<int>() { 10, 20, 30, 40 };
			var list_2 = new List<int>() { 20, 30, 40 };
			Console.WriteLine(SubsequenceFinder.subseqs(list_1, list_2));

		}

	}

	public class SubsequenceFinder
	{
		/// <summary>
		/// Determines whether a list of integers is a subsequence of another list of integers
		/// </summary>
		/// <param name="seq">The main sequence of integers.</param>
		/// <param name="subseq">The potential subsequence.</param>
		/// <returns>True if subseq is a subsequence of seq and false otherise.</returns>
		///

		public static bool subseqs(List<int> seq, List<int> subseq)
		{
			var first = seq.IndexOf(subseq.First());
			if (seq == null || subseq == null || first < 0)
				return false;

			while (first >= 0)
			{
				if (seq.Count - first < subseq.Count)
					return false;
				var notequal = false;
				for (int i = 0; i < subseq.Count; i++)
				{
					// to check subsequence or not
					if (seq[i + first] != subseq[i])
					{
						// if not then skip and next 
						seq = seq.Skip(first + 1).ToList();
						//to store next number
						first = seq.IndexOf(subseq.First());
						//if not match then notequal is true
						notequal = true;
						break;
					}
				}
				if (!notequal)
					return true;
			}
			return false;
		}




	}
	class CardPicker
	{
		static Random random = new Random(1);
		/// <summary>
		/// Picks a random (with replacement) number of cards.
		/// </summary>
		/// <param name="numCards">The number of cards to choose at random.</param>
		/// <returns>An array of strings where each string represents a card.</returns>
		public static string[] PickSomeCards(int numCards)
		{
			// Use RandomValue() & RandomSuit() to help you here
			throw new NotImplementedException();
		}
		/// <summary>
		/// Chooses a random value for a card (Ace, 2, 3, ... , Queen, King)
		/// </summary>
		/// <returns>A string that represents the value of a card</returns>
		private static string RandomValue()
		{
			throw new NotImplementedException();
		}
		/// <summary>
		/// Chooses a random suit for a card (Clubs, Diamonds, Hearts, Spades)
		/// </summary>
		/// <returns>A string that represents the suit of a card.</returns>
		private static string RandomSuit()
		{
			throw new NotImplementedException();
		}
	}
}

