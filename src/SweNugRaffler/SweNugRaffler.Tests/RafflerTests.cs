using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SweNugRaffler.Core;

namespace SweNugRaffler.Tests
{
    [TestFixture]
    public class RafflerTests
    {
        [Test]
        public void Raffler_list_is_initialized_empty()
        {
            var raffler = new Raffler();

            Assert.IsNotNull(raffler.Entrants);
        }

        [Test]
        public void Can_add_one_entrant()
        {
            var raffler = new Raffler();
            raffler.AddEntrant("Per Persson");

            Assert.AreEqual(1, raffler.NumberOfEntrants());
        }

        [Test]
        public void Can_return_a_winner()
        {
            var raffler = new Raffler();

            raffler.AddEntrant("Johan Johansson");

            raffler.AddEntrant("Per Persson");

            string winner = raffler.GetRandomWinner();

            Assert.IsNotNullOrEmpty(winner);;
        }

        [Test]
        public void Returns_specific_winner_when_only_one_entrant()
        {
            var raffler = new Raffler();
            var expected = "Per Persson";
            raffler.AddEntrant(expected);

            Assert.AreEqual(expected, raffler.GetRandomWinner());
        }
    }
}
