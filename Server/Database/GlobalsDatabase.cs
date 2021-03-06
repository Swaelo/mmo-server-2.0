﻿// ================================================================================================================================
// File:        GlobalsDatabase.cs
// Description: Allows the server to interact with the local SQL database globals table
// Author:      Harley Laurie https://www.github.com/Swaelo/
// ================================================================================================================================

using MySql.Data.MySqlClient;

namespace Server.Database
{
    class GlobalsDatabase
    {
        //Queries the server to find out what the next ItemID will be for when the ItemManager next adds a new item into the game
        public static int GetNextItemID()
        {
            //Define new query/command used to fetch the NextItemID value from the globals database
            string NextItemIDQuery = "SELECT NextItemID FROM globals";
            return CommandManager.ExecuteScalar(NextItemIDQuery, "Fetching the NextItemID value from the globals database");
        }

        //Updates the value in the database for what the next ItemID will be for the ItemManager to add a new item into the game
        public static void SaveNextItemID(int NextItemID)
        {
            //Define new query/command used to update the NextItemID value in the globals database
            string NextItemIDQuery = "UPDATE globals SET NextItemID='" + NextItemID + "'";
            CommandManager.ExecuteNonQuery(NextItemIDQuery, "Updating the NextItemID value in the globals database");
        }
    }
}
