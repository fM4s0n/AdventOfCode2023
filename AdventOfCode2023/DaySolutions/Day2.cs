﻿using System.Data.SqlTypes;

namespace AdventOfCode2023.DaySolutions;

internal static class Day2
{
    static readonly string puzzleInput = "Game 1: 4 green, 2 blue; 1 red, 1 blue, 4 green; 3 green, 4 blue, 1 red; 7 green, 2 blue, 4 red; 3 red, 7 green; 3 red, 3 green\r\nGame 2: 1 blue, 11 red, 1 green; 3 blue, 2 red, 4 green; 11 red, 2 green, 2 blue; 13 green, 5 red, 1 blue; 4 green, 8 red, 3 blue\r\nGame 3: 9 red, 2 blue; 4 blue, 2 green, 1 red; 7 red, 4 blue, 3 green; 3 blue, 6 red; 9 blue, 4 red; 3 red\r\nGame 4: 5 blue, 11 green, 3 red; 6 green, 3 blue, 7 red; 17 blue, 9 green; 1 red, 5 blue, 3 green; 6 red, 7 blue, 4 green\r\nGame 5: 3 green, 7 blue, 7 red; 6 green, 3 red, 4 blue; 7 blue, 4 red\r\nGame 6: 1 green, 3 blue; 2 blue, 9 red; 2 green, 13 blue, 11 red; 7 red, 12 blue, 1 green\r\nGame 7: 2 blue, 6 red, 12 green; 7 red, 8 blue, 6 green; 7 blue, 3 green, 7 red; 5 blue, 9 green, 13 red\r\nGame 8: 13 blue, 1 green; 3 red, 9 blue; 3 red, 4 blue; 2 red, 3 blue, 1 green; 1 green, 15 blue, 4 red\r\nGame 9: 1 green, 5 blue, 11 red; 2 red, 1 blue; 2 red, 5 blue\r\nGame 10: 8 red, 20 green; 12 green, 1 red, 2 blue; 5 red, 3 blue, 7 green; 4 red, 19 green, 6 blue; 3 blue, 4 red, 14 green; 9 red, 15 green\r\nGame 11: 7 green, 4 blue, 14 red; 7 red, 8 green; 6 blue, 6 red; 5 blue, 10 red, 11 green; 12 red, 2 green\r\nGame 12: 4 blue, 5 green, 8 red; 2 green, 4 blue, 7 red; 4 blue, 3 green, 2 red; 2 red, 4 green\r\nGame 13: 7 blue, 8 red; 5 green, 15 blue, 2 red; 7 green, 3 blue, 12 red\r\nGame 14: 4 green, 16 red; 6 red, 2 green; 5 red, 1 blue, 3 green; 1 blue, 1 red, 2 green\r\nGame 15: 3 green; 2 blue, 1 red, 2 green; 6 blue; 3 blue, 1 red, 2 green; 2 red, 1 green\r\nGame 16: 13 green, 3 red; 9 green, 1 blue; 4 blue, 1 red, 18 green; 2 red, 3 blue, 7 green; 17 green, 2 red, 3 blue; 12 green, 2 red\r\nGame 17: 2 blue, 4 green, 3 red; 2 red, 5 green, 11 blue; 5 green, 15 blue, 2 red; 3 green, 13 blue; 6 blue, 2 green, 2 red; 8 blue, 1 red\r\nGame 18: 6 red, 4 green, 7 blue; 2 red, 3 green, 12 blue; 3 red, 6 blue, 6 green; 9 red, 10 blue; 6 green, 4 blue, 2 red; 12 red, 12 blue, 9 green\r\nGame 19: 3 blue, 2 red, 3 green; 16 red, 3 blue, 5 green; 2 red, 6 green; 3 green, 2 blue, 15 red; 2 blue, 13 red, 1 green\r\nGame 20: 2 blue; 1 green, 5 blue, 2 red; 3 blue, 2 red, 1 green; 1 red, 2 blue\r\nGame 21: 15 green, 13 blue, 4 red; 9 green, 6 red, 19 blue; 6 blue, 1 green, 1 red; 1 red, 11 green, 9 blue; 3 red, 14 green, 8 blue\r\nGame 22: 3 blue, 10 red, 1 green; 2 red, 6 green; 9 green, 3 blue, 4 red; 2 blue, 4 green\r\nGame 23: 5 red, 2 green, 5 blue; 4 green, 12 red, 2 blue; 3 green, 8 red, 4 blue\r\nGame 24: 1 green, 16 red, 3 blue; 10 red, 1 blue; 2 blue, 1 green, 7 red; 12 red, 1 green; 14 red, 1 green; 1 blue, 8 red, 1 green\r\nGame 25: 8 blue, 9 red, 6 green; 2 blue, 4 green, 8 red; 1 green, 9 blue, 2 red; 14 red, 4 blue\r\nGame 26: 4 blue, 3 green; 1 red, 3 blue; 6 red, 2 green, 6 blue; 5 green, 2 red; 5 blue, 5 green; 6 red, 1 blue\r\nGame 27: 6 green, 9 blue; 1 red, 6 green, 8 blue; 3 green, 1 blue, 1 red; 3 red, 4 blue; 2 red, 2 blue; 4 red, 3 green, 7 blue\r\nGame 28: 5 green, 2 blue; 5 blue; 1 red, 4 blue, 3 green; 1 green, 2 red\r\nGame 29: 1 green, 2 red, 4 blue; 1 green, 2 red, 1 blue; 9 red, 6 blue\r\nGame 30: 1 green, 1 red, 5 blue; 13 blue, 4 green, 2 red; 10 green, 11 blue; 9 green, 2 red, 12 blue\r\nGame 31: 4 red, 5 blue; 8 blue, 1 red, 1 green; 4 red, 5 green; 3 green; 9 blue, 2 red, 7 green\r\nGame 32: 5 blue, 4 red, 5 green; 10 red, 10 green, 5 blue; 10 red, 12 green, 6 blue; 8 red, 1 blue, 13 green; 6 green, 14 red, 2 blue\r\nGame 33: 9 green, 6 red, 4 blue; 1 red, 2 blue, 13 green; 4 red, 4 green, 5 blue\r\nGame 34: 1 blue, 1 red; 9 green, 14 red, 1 blue; 3 blue, 7 green\r\nGame 35: 1 red, 11 green, 5 blue; 1 red, 5 blue, 17 green; 19 green, 6 blue; 4 green, 7 blue; 10 blue, 7 green\r\nGame 36: 9 green, 6 blue, 4 red; 8 blue, 13 green, 1 red; 5 blue, 5 green; 15 green, 1 red\r\nGame 37: 1 green, 9 red, 1 blue; 14 green; 11 green, 6 red\r\nGame 38: 2 blue; 9 green, 1 blue, 8 red; 4 green, 1 blue, 3 red\r\nGame 39: 7 red, 7 blue; 3 green, 6 blue, 2 red; 3 green, 4 red\r\nGame 40: 5 blue, 2 red, 6 green; 6 blue, 10 green, 4 red; 8 green, 6 blue; 3 green, 2 blue; 2 red, 14 green\r\nGame 41: 5 red, 14 blue, 3 green; 3 red, 3 blue, 7 green; 19 blue, 15 green, 6 red; 5 green, 18 blue; 1 green, 7 red, 9 blue; 14 green, 10 blue, 1 red\r\nGame 42: 2 red, 3 green; 2 blue, 3 red; 15 green, 1 blue; 2 blue, 15 green, 1 red; 7 red, 15 green\r\nGame 43: 4 green, 6 red, 9 blue; 4 green, 3 red, 18 blue; 6 green, 7 blue; 4 red, 7 blue; 8 blue, 7 green, 1 red; 5 red, 14 blue\r\nGame 44: 2 green, 11 blue; 1 green, 5 red, 8 blue; 4 green, 17 blue, 4 red\r\nGame 45: 6 blue, 3 green, 2 red; 8 green, 12 blue, 3 red; 13 blue, 11 green; 13 blue, 9 green; 2 blue, 3 green, 3 red; 2 blue, 10 green\r\nGame 46: 14 blue, 12 green, 3 red; 2 green, 1 red, 10 blue; 5 red, 7 green\r\nGame 47: 15 blue, 1 red; 1 red, 14 blue; 1 red, 16 blue; 3 green, 8 blue\r\nGame 48: 1 green, 3 blue, 1 red; 8 blue, 2 red, 8 green; 14 red, 4 green, 11 blue\r\nGame 49: 6 red, 5 blue, 2 green; 3 red, 11 blue; 1 blue, 14 green, 6 red\r\nGame 50: 7 red, 7 blue; 7 blue, 7 red; 13 blue, 1 green, 2 red; 7 green, 5 red, 9 blue\r\nGame 51: 4 blue, 9 red, 1 green; 16 red; 2 blue, 6 red; 11 red, 6 blue\r\nGame 52: 4 green, 4 blue, 9 red; 5 blue, 4 red, 16 green; 16 green, 3 red\r\nGame 53: 2 green, 12 red; 2 red, 5 green, 15 blue; 9 blue, 17 red, 9 green; 2 blue, 6 red, 4 green\r\nGame 54: 2 red, 3 blue, 5 green; 8 green, 3 blue; 9 green, 3 blue, 3 red; 1 blue, 4 green\r\nGame 55: 6 green, 11 blue, 12 red; 10 blue, 6 red, 13 green; 7 green, 9 blue; 10 green, 20 red, 7 blue; 9 green, 14 red, 8 blue; 14 green, 15 red\r\nGame 56: 1 green, 8 red, 1 blue; 1 green, 3 blue, 13 red; 5 red, 3 blue; 5 blue, 16 red; 12 red, 4 blue\r\nGame 57: 7 green, 5 blue; 13 blue; 1 red, 11 green, 4 blue; 1 red, 7 green, 5 blue\r\nGame 58: 14 blue, 6 green, 9 red; 7 blue, 1 green, 11 red; 3 red, 9 blue, 6 green; 4 green, 2 red; 2 blue, 6 green; 11 blue, 1 red\r\nGame 59: 6 red, 1 blue, 5 green; 4 green; 15 green; 7 red, 1 blue, 12 green; 7 red, 1 blue, 3 green\r\nGame 60: 3 blue, 6 red, 2 green; 7 green, 6 red, 4 blue; 3 green, 1 red, 4 blue; 3 red, 1 green; 9 red, 5 green, 4 blue\r\nGame 61: 1 green, 3 blue; 1 red, 2 green; 1 green, 2 blue, 2 red\r\nGame 62: 10 green, 15 blue, 14 red; 11 blue, 11 red, 16 green; 5 red, 5 green, 12 blue\r\nGame 63: 2 blue, 5 red; 7 blue, 2 green, 2 red; 2 red, 1 blue\r\nGame 64: 9 blue, 12 red, 4 green; 5 blue, 13 red; 1 red, 2 green, 7 blue\r\nGame 65: 4 blue, 8 red; 13 green, 8 blue, 5 red; 1 green, 5 blue, 7 red; 11 red, 7 blue, 10 green\r\nGame 66: 8 red, 17 blue; 1 green, 9 red, 7 blue; 12 red\r\nGame 67: 14 blue, 12 green, 3 red; 12 green; 9 green, 13 red, 15 blue; 2 red, 10 green, 1 blue\r\nGame 68: 11 blue, 14 green; 14 green; 9 blue, 7 green, 1 red; 9 blue, 7 green; 17 green, 2 blue; 4 green, 4 blue\r\nGame 69: 4 blue, 14 green, 6 red; 11 red, 7 green, 10 blue; 4 red, 8 blue, 8 green; 7 green, 6 red, 7 blue\r\nGame 70: 12 red, 16 green, 11 blue; 16 green, 15 blue, 5 red; 10 blue, 1 red, 12 green; 9 red, 8 blue, 4 green; 2 green, 8 red, 3 blue\r\nGame 71: 8 red, 1 blue, 5 green; 12 green, 7 red; 11 green, 1 blue, 7 red\r\nGame 72: 5 green, 15 red; 7 green, 3 red, 4 blue; 10 red, 1 green; 6 blue, 15 red, 3 green\r\nGame 73: 1 green, 5 red, 1 blue; 6 red, 3 blue, 6 green; 11 red, 1 blue\r\nGame 74: 5 red; 1 blue, 3 green, 3 red; 2 green, 7 red; 1 blue, 2 red; 3 red, 1 green\r\nGame 75: 13 blue, 20 red, 10 green; 3 green, 5 blue, 14 red; 9 red, 13 green, 7 blue; 1 blue, 15 red, 2 green; 11 blue, 2 green, 17 red; 11 red, 13 blue, 13 green\r\nGame 76: 9 red, 7 green, 2 blue; 7 red, 2 blue, 8 green; 4 blue, 3 red, 9 green; 4 red, 1 green; 1 red, 2 green, 3 blue\r\nGame 77: 5 red, 2 green, 15 blue; 12 green, 4 red, 2 blue; 10 blue, 6 red, 9 green; 7 blue, 3 green; 16 blue, 4 red, 5 green\r\nGame 78: 11 blue, 3 green, 19 red; 3 blue, 1 red; 8 red, 14 blue, 3 green; 8 blue, 8 green, 16 red; 8 blue, 14 red; 12 blue, 11 red, 2 green\r\nGame 79: 10 blue, 5 red, 1 green; 3 blue, 13 red; 15 red, 1 green; 4 red, 6 blue, 1 green; 1 green, 6 blue\r\nGame 80: 7 red, 1 green, 1 blue; 1 blue, 4 red, 3 green; 2 red, 2 green; 7 red, 1 blue, 1 green; 2 red, 1 green, 3 blue\r\nGame 81: 12 green, 2 red, 8 blue; 1 green, 1 blue, 1 red; 7 blue, 1 red, 11 green; 1 red, 12 blue, 4 green\r\nGame 82: 18 red, 5 blue, 4 green; 6 green, 11 red; 11 green, 18 red, 5 blue; 4 green, 17 red, 4 blue; 5 blue, 14 red, 15 green\r\nGame 83: 4 red, 6 blue, 6 green; 9 red, 4 green; 8 green, 7 blue; 2 blue, 9 red, 13 green; 2 blue, 9 green, 11 red\r\nGame 84: 15 blue; 4 green, 1 red, 15 blue; 2 green, 16 blue; 3 green, 14 blue; 16 blue\r\nGame 85: 3 red, 7 green, 8 blue; 3 blue, 17 green, 7 red; 13 green, 4 blue; 6 blue, 8 green\r\nGame 86: 16 green, 6 blue; 12 blue, 9 red, 11 green; 17 green, 4 blue, 8 red\r\nGame 87: 6 blue, 3 green, 13 red; 13 blue; 12 red, 2 green, 1 blue\r\nGame 88: 6 red, 2 blue; 16 red, 13 blue, 1 green; 2 green, 11 blue, 2 red; 12 blue, 9 red, 1 green; 5 blue, 2 red, 2 green; 18 red, 3 blue\r\nGame 89: 6 green, 5 blue; 4 green, 4 blue; 3 red, 5 blue\r\nGame 90: 3 green, 8 blue; 2 green, 7 blue, 9 red; 8 red, 2 blue, 4 green; 1 green, 3 red, 7 blue; 4 blue, 4 green, 2 red; 9 red, 3 blue, 3 green\r\nGame 91: 9 red, 12 green, 1 blue; 11 green, 9 red, 2 blue; 1 blue, 8 red, 4 green; 6 red, 9 green; 2 blue, 10 red, 1 green; 2 blue, 15 green, 13 red\r\nGame 92: 3 green, 11 red, 16 blue; 8 blue, 1 red, 6 green; 4 green, 1 red, 5 blue\r\nGame 93: 9 blue, 3 red, 13 green; 2 red, 9 blue; 3 blue, 17 green, 5 red; 4 green, 8 blue\r\nGame 94: 2 blue, 3 red, 9 green; 4 blue, 1 red, 6 green; 8 green, 2 blue; 4 green, 2 blue, 7 red\r\nGame 95: 5 green, 3 blue; 4 blue, 3 green, 8 red; 3 green, 4 red, 3 blue; 2 blue, 4 red; 9 blue, 5 red, 3 green\r\nGame 96: 11 green; 10 green, 5 blue, 11 red; 5 blue, 13 red, 15 green; 10 green, 1 blue, 11 red\r\nGame 97: 5 green, 6 blue, 1 red; 7 green, 1 red; 5 blue; 3 blue, 1 red\r\nGame 98: 1 blue, 5 green, 7 red; 3 red, 5 green, 1 blue; 4 blue, 8 green, 2 red; 4 green, 1 blue, 6 red\r\nGame 99: 12 blue, 8 green; 2 green; 3 red, 7 green, 5 blue; 1 green, 1 blue, 2 red\r\nGame 100: 4 blue, 14 red; 12 red, 1 blue; 2 red, 2 blue; 8 red; 14 red, 2 blue, 1 green; 3 blue";
    static readonly string testInput = "Game 1: 3 blue, 4 red; 1 red, 2 green, 6 blue; 2 green\r\nGame 2: 1 blue, 2 green; 3 green, 4 blue, 1 red; 1 green, 1 blue\r\nGame 3: 8 green, 6 blue, 20 red; 5 blue, 4 red, 13 green; 5 green, 1 red\r\nGame 4: 1 green, 3 red, 6 blue; 3 green, 6 red; 3 green, 15 blue, 14 red\r\nGame 5: 6 red, 1 blue, 3 green; 2 blue, 1 red, 2 green";

    internal static int RunDay2Pt1()
    {
        int total = 0;
        List<int> gamesPassed = new();

        int redCubeMax = 12;
        int greenCubeMax = 13;
        int blueCubeMax = 14;

        List<string> games = [..puzzleInput.Split("\r\n")];

        foreach (string game in games)
        {
            bool gamePossible = false;

            int gameId = Convert.ToInt32(game.Split(": ")[0].Remove(0, 5));
            string gameString = game.Split(": ")[1];

            List<string> sets = [.. gameString.Split("; ")];

            foreach (string setString in sets)
            {
                int redCount = 0;
                int greenCount = 0;
                int blueCount = 0;

                List<string> cubeNums = [.. setString.Split(", ")];

                foreach (string cubeNum in cubeNums)
                {
                    int num = Convert.ToInt32(cubeNum.Split(" ")[0]);
                    string colour = cubeNum.Split(" ")[1];

                    switch (colour)
                    {
                        case "red":
                            redCount += num;
                            break;
                        case "green":
                            greenCount += num;
                            break;
                        case "blue":
                            blueCount += num;
                            break;
                    }
                }
                if (redCount <= redCubeMax && greenCount <= greenCubeMax && blueCount <= blueCubeMax)
                    gamePossible = true;
                else
                {
                    gamePossible = false;
                    break;
                }
            }

            //if all sets possible
            if (gamePossible)
            {
                total += gameId;
                gamesPassed.Add(gameId);
            }
        }

        return total;
    }

    internal static int RunDay2Pt2()
    {
        int total = 0;

        List<string> games = [..puzzleInput.Split("\r\n")];

        foreach (string game in games)
        {
            int minRed = 0;
            int minGreen = 0;
            int minBlue = 0;

            string gameString = game.Split(": ")[1];
            List<string> sets = [.. gameString.Split("; ")];

            foreach (string set in sets)
            {
                List<string> cubeNums = [..set.Split(", ")];
                foreach (string cubeNum in cubeNums)
                {
                    int num = Convert.ToInt32(cubeNum.Split(" ")[0]);
                    string colour = cubeNum.Split(" ")[1];

                    switch (colour)
                    {
                        case "red":
                            if (num > minRed)
                                minRed = num;
                            break;
                        case "green":
                            if (num > minGreen)
                                minGreen = num;
                            break;
                        case "blue":
                            if (num > minBlue)
                                minBlue = num;
                            break;
                    }
                }
            }

            total += minRed * minGreen * minBlue;
        }
        return total;
    }
}
