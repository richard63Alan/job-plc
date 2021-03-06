using System;
using System.IO;
using exercise_18;
using NUnit.Framework;
using System.Text.RegularExpressions;

namespace ProgramTests
{
  [TestFixture]
  public class TestProgram
  {
    [Test]
    public void TestExercise18Test1()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        var data = String.Join(Environment.NewLine, new[]
        {
                "2",
                "4",
                "5"
                });

        Console.SetIn(new System.IO.StringReader(data));

        // Call student's code
        Program.Main(null);

        // Restore the original standard output.
        Console.SetOut(stdout);

        // Assert
        Assert.AreEqual("Give the first number!\nGive the second number!\nGive the third number!\nThe sum is 11\n", sw.ToString().Replace("\r\n", "\n"), "Did you get the sum correctly?");
      }
    }

     [Test]
    public void TestExercise18Test2()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        var data = String.Join(Environment.NewLine, new[]
        {
                "-42",
                "4",
                "371"
                });

        Console.SetIn(new System.IO.StringReader(data));

        // Call student's code
        Program.Main(null);

        // Restore the original standard output.
        Console.SetOut(stdout);

        // Assert
        Assert.AreEqual("Give the first number!\nGive the second number!\nGive the third number!\nThe sum is 333\n", sw.ToString().Replace("\r\n", "\n"), "Did you get the sum correctly?");
      }
    }
  }
}