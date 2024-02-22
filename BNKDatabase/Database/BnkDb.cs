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
            {
                Console.WriteLine("ERROR: ID WAS LESS THAN 1");
                return null;
            }

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
                    Console.WriteLine("ERROR: UNKOWN STORY PROPERTY");
                    return null;
            }
        }

        public int GetPropAmount(string table)
        {
            return GetRowAmount(table);
        }

        public List<int> GetWCProfessionsIDs(int id)
        {
            return GetWCRelatedIDs(
                id,
                BnkDbStruct.WinConditionCol.professions,
                BnkDbStruct.WinConditionTable.wcprofessions,
                BnkDbStruct.WCProfessionsColumnSketch.name,
                BnkDbStruct.WinConditionTable.wcProfAmount
                );
        }

        public List<int> GetWCItemsIDs(int id)
        {
            return GetWCRelatedIDs(
                id,
                BnkDbStruct.WinConditionCol.items,
                BnkDbStruct.WinConditionTable.wcitems,
                BnkDbStruct.WCItemsColumnSketch.name,
                BnkDbStruct.WinConditionTable.wcItemsAmount
                );
        }

        List<int> GetWCRelatedIDs(
            int wincond_id,
            string wcForeignColumn,
            string wcRelatedTable,
            string wcRelatedColumnSketch,
            int wcRelatedColAmount)
        {
            if (wincond_id <= 0)
            {
                Console.WriteLine("ERROR: ID WAS LESS THAN 1");
                return null;
            }

            string wcForeignKeyStr = GetValueByID(BnkDbStruct.WinConditionTable.wincondition, wcForeignColumn, wincond_id.ToString());

            if (wcForeignKeyStr == null)
            {
                return null;
            }

            List<int> result = new List<int>();

            for (int i = 0; i < wcRelatedColAmount; i++)
            {
                string relatedID = GetValueByID(
                    wcRelatedTable,
                    (wcRelatedColumnSketch + (i + 1).ToString()),
                    wcForeignKeyStr);
                if (relatedID != null)
                {
                    result.Add(int.Parse(relatedID));
                }
            }

            if (result.Count == 0)
            {
                Console.WriteLine("WARNING: WINCONDITION TABLE FOREIGN KEY EXIST BUT RELATING TABLE HAS NO VALUES BY THIS KEY");
            }
            return result;
        }

        string GetValueByID(string table, string column, string id)
        {
            if (database == null)
            {
                Console.WriteLine("ERROR: NO DATABASE LOADED");
                return null;
            }

            using (var command = database.CreateCommand())
            {
                command.CommandText = $"SELECT {column} FROM '{table}' WHERE id = '{id}'";
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read() && !reader.IsDBNull(0))
                    {
                        var t = reader.GetDataTypeName(0);
                        if(t == "TEXT")                                             //Thoughts: Shall I rework this to handle any sqlite return type?
                        {
                            return reader.GetString(0);
                        }
                        else if(t == "INTEGER")
                        {
                            return reader.GetInt32(0).ToString();
                        }
                        else
                        {
                            Console.WriteLine("ERROR: UNKOWN DATA TYPE OF THE CELL - METHOD GetValueByID");
                            return null;
                        }
                    }
                    else
                    {
                        Console.WriteLine("WARNING: VALUE WAS NULL");
                        return null;
                    }
                }
            }
        }

        int GetRowAmount(string table)
        {
            if (database == null)
            {
                Console.WriteLine("ERROR: NO DATABASE LOADED");
                return -1; 
            }

            using (var command = database.CreateCommand())
            {
                command.CommandText = $"SELECT * FROM '{table}'";
                using (var reader = command.ExecuteReader())
                {
                    int counter = 0;
                    while (reader.Read() && !reader.IsDBNull(0))
                    {
                        counter++;
                    }
                    return counter;
                }
            }
        }
    }
}
