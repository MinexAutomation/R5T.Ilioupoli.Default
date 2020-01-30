﻿using System;


namespace R5T.Ilioupoli.Default
{
    public class TestingDataDirectoryContentConventions : ITestingDataDirectoryContentConventions
    {
        public const string BasicTextFileNameValue = "Basic Text File.txt";

        public const string ExampleVisualStudioSolutionFileNameValue = "R5T.Canterbury.Standard.sln";


        public string BasicTextFileName => TestingDataDirectoryContentConventions.BasicTextFileNameValue;

        public string ExampleVisualStudioSolutionFileName => TestingDataDirectoryContentConventions.ExampleVisualStudioSolutionFileNameValue;
    }
}