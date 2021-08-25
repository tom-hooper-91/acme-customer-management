using System;
using Acme.Common;
using Xunit;

namespace Acme.CommonTest
{
    public class StringHandlerTest
    {
        [Fact]
        public void InsertSpacesToTestValid()
        {
            //arrange
            var source = "SonicScrewdriver";
            var expected = "Sonic Screwdriver";

            //act
            var actual = source.InsertSpaces();

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void InsertSpacesToExistingSpace()
        {
            //arrange
            var source = "Sonic Screwdriver";
            var expected = "Sonic Screwdriver";

            //act
            var actual = source.InsertSpaces();

            //assert
            Assert.Equal(expected, actual);
        }
    }
}
