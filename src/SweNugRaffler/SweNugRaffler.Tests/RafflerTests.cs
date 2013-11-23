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
    }
}
