using FluentAssertions;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquation.Tests.Systems.QuadraticEquation
{
    public class TestQuadraticEquation
    {
        [Theory]
        [InlineData(2,5,-3.5, -3.07, 0.57)]
        [InlineData(1,4,1, -3.73, -0.27)]
        public void Get_OnSuccess_QuadraticResult(double a, double b, double c, double expectedX1, double expectedX2)
        {
            var result = QuadraticSolver.Solve(a, b, c);
            result.Should().NotBeNull();
            result.Value.x1.Should().Be(expectedX1);
            result.Value.x2.Should().Be(expectedX2);
        }

        [Theory]
        [InlineData(1, 0, 1)]
        [InlineData(1, 1, 1)]
        public void Get_OnSuccess_NullResult(double a, double b, double c)
        {
            var result = QuadraticSolver.Solve(a, b, c);
            result.Should().BeNull();
        }
    }
}
