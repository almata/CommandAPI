using System;
using Xunit;
using CommandAPI.Models;

namespace CommandAPI.Tests
{
    public class CommandTests : IDisposable
    {
        Command testCommand;

        public CommandTests()
        {
            testCommand = new Command
            {
                HowTo = "Do something",
                Platform = "Some platform",
                CommandLine = "Some command line"
            };
        }

        public void Dispose()
        {
            testCommand = null;
        }

        [Fact]
        public void CanChangeHowTo()
        {
            // Arrange

            // Act
            testCommand.HowTo = "Execute unit tests";

            // Assert
            Assert.Equal("Execute unit tests", testCommand.HowTo);
        }

        [Fact]
        public void CanChangePlatform()
        {
            // Arrange

            // Act
            testCommand.Platform = "xUnit";

            // Assert
            Assert.Equal("xUnit", testCommand.Platform);
        }

        [Fact]
        public void CanChangeCommandLine()
        {
            // Arrange

            // Act
            testCommand.CommandLine = "dotnet test";

            // Assert
            Assert.Equal("dotnet test", testCommand.CommandLine);
        }                
    }
}