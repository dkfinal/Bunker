using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SQLite;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using BNKDatabase.Types;
using Common.BNKProperties;

namespace BNKDatabase
{
    public class BnkDb
    {
        SQLiteConnection database;
        public BnkDb()
        {
            

        }

        ~BnkDb()
        {
            if (database != null)
            {
                database.Close();
                database.Dispose();
            }
        }

        public bool Connect()
        {
            try
            {
                database = new SQLiteConnection($"Data Source=./Data/BNK.db;Mode=ReadOnly;Cache=Shared");
                database.Open();
                return true;
            }
            catch (SQLiteException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }



        public string GetPersonProp(int id, string personProperty)
        {
            if (id <= 0)
                return "ERROR: ID WAS LESS THAN 1";

            var getval = (string table) => { return GetValueByID(table, BnkDbStruct.PersonPropertyCol.name, id.ToString()); };

            switch (personProperty) 
            {
                case PersonProperty.age:
                    return getval(BnkDbStruct.PersonTable.age);
                case PersonProperty.health:
                    return getval(BnkDbStruct.PersonTable.health);
                case PersonProperty.hobby:
                    return getval(BnkDbStruct.PersonTable.hobby);
                case PersonProperty.item:
                    return getval(BnkDbStruct.PersonTable.item);
                case PersonProperty.profession:
                    return getval(BnkDbStruct.PersonTable.profession);
                case PersonProperty.race:
                    return getval(BnkDbStruct.PersonTable.race);
                case PersonProperty.sex:
                    return getval(BnkDbStruct.PersonTable.sex);
                case PersonProperty.skill:
                    return getval(BnkDbStruct.PersonTable.skill);
                case PersonProperty.weakness:
                    return getval(BnkDbStruct.PersonTable.weakness);
                default:
                    return "ERROR: UNKOWN PERSON PROPERTY";
            }
        }

        public string GetWCProp(int id, string storyProperty)
        {
            if (id <= 0)
                return "ERROR: ID WAS LESS THAN 1";

            var getval = (string column) => { return GetValueByID(BnkDbStruct.WinConditionTable.wincondition, column, id.ToString()); };

            switch (storyProperty)
            {
                case StoryProperty.name:
                    return getval(BnkDbStruct.WinConditionCol.name);
                case StoryProperty.maxplayers:
                    return getval(BnkDbStruct.WinConditionCol.maxplayers);
                case StoryProperty.breed:
                    return getval(BnkDbStruct.WinConditionCol.breed);
                case StoryProperty.opening:
                    return getval(BnkDbStruct.WinConditionCol.opening);
                case StoryProperty.goodend:
                    return getval(BnkDbStruct.WinConditionCol.goodend);
                case StoryProperty.badend:
                    return getval(BnkDbStruct.WinConditionCol.badend);
                default:
                    return "ERROR: UNKOWN STORY PROPERTY";
            }
        }

        public List<string> GetWCProfessions(int id)
        {
            return null;
        }

        public List<string> GetWCItems(int id)
        {
            return null;
        }

        public int GetPropAmount(string table)
        {
            return GetRowAmount(table);
        }

        string GetValueByID(string table, string column, string id)
        {
            if (database == null)
                return "ERROR: NO DATABASE LOADED";

            using (var command = database.CreateCommand())
            {
                command.CommandText = $"SELECT {column} FROM '{table}' WHERE id = '{id}'";
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return reader.GetString(0);
                    }
                    else
                    {
                        return "NULL";
                    }
                }
            }
        }

        int GetRowAmount(string table)
        {
            if (database == null)
                return -1;

            using (var command = database.CreateCommand())
            {
                command.CommandText = $"SELECT * FROM '{table}'";
                using (var reader = command.ExecuteReader())
                {
                    int counter = 0;
                    while (reader.Read())
                    {
                        counter++;
                    }
                    return counter;
                }
            }
        }
    }
}
