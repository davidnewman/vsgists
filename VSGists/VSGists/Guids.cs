// Guids.cs
// MUST match guids.h
using System;

namespace DavidNewman.VSGists
{
    static class GuidList
    {
        public const string guidVSGistsPkgString = "5f3b3805-09d9-4c2c-ab19-e47c49f2b589";
        public const string guidVSGistsCmdSetString = "513e4480-8a7a-4270-ae51-d7aacf010316";

        public static readonly Guid guidVSGistsCmdSet = new Guid(guidVSGistsCmdSetString);
    };
}