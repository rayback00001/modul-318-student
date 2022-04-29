using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using SwissTransport.Core;
using SwissTransport.Models;
using Xunit;

namespace SwissTransport
{
    public class ApplikationTest
    {
        private readonly ITransport testee;
        public ApplikationTest()
        {
            this.testee = new Transport();

        }

        [Fact]
        public void Test()
        {
            Stations stations = this.testee.GetStations("Willisau,");

            stations.StationList.Should().NotBeNull();
        }
    }
}
