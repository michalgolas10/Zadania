using FluentAssertions;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using ZadaniaRekrutacyjne.Utility;

namespace ZadaniaRekrutacyjne.UnitTests.Utility
{
    public class IfNumberSplitedStringAttributeUnitTests
    {
        [Fact]
        public void IfNumberSplitedStringAttribute_CorrectInput2DimensionMatrix_ReturnsValidationResultSucces()
        {
            //Arrange
            var value = new String("1011,1011");
            var attrib = new IfNumberSplitedStringAttribute();
            //Act
            var result = attrib.IsValid(value);
            //Assert
            result.Should().Be(true);
        }
        [Fact]
        public void IfNumberSplitedStringAttribute_1DimensionMatrixInputCorrect_ReturnsValidationResultSucces()
        {
            //Arrange
            var value = new String("100");
            var attrib = new IfNumberSplitedStringAttribute();
            //Act
            var result = attrib.IsValid(value);
            //Assert
            result.Should().Be(true);
        }
    }
}
