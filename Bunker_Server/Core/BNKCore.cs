﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using BNKDatabase;
using Bunker_Server.Server;
using Common;
using Common.BNKProperties;
using Common.Network.Message.high;

namespace Bunker_Server
{
    internal class BNKCore
    {
        BNKServer server;
        BnkDb bnkdb;
        StoryCard story;

        public BNKCore()
        {
            server = new BNKServer();

            bnkdb = new BnkDb();
            bnkdb.Connect();
        }

        public List<string> GetStoryList()
        {
            List<string> storylst = new List<string>();
            int stroyamount = bnkdb.GetPropertyAmount(StoryProperty.name);
            for (int i = 0; i < stroyamount; i++)
            {
                string storyname = bnkdb.GetWCProp(i + 1, StoryProperty.name);
                if (storyname != null)
                {
                    storylst.Add(storyname);
                }
                else
                {
                    storylst.Add("Unnamed story" + (i + 1).ToString()); //TODO: wrapper for standart phrases
                }
            }
            return storylst;
        }

        public void CreateStory(int id)
        {
            story = StoryCardMethod(id++);
        }
        public int GetStoryMinClients()
        {
            return story.minPlayers;
        }

        public void GameStart()
        {

        }

        public int ManageConnection()
        {
            return server.ListenConnections();
        }

        public int KeepAliveClients()
        {
            return server.KeepAlive();
        }

        public void ReadAsyncClients(Action<BunkerMessage, NetworkStream> executeRequest)
        {
            server.ReadAsync(executeRequest);
        }

        StoryCard StoryCardMethod(int id)
        {
            id++;
            string name = bnkdb.GetWCProp(id, StoryProperty.name);
            int minplayers = int.Parse(bnkdb.GetWCProp(id, StoryProperty.minplayers));
            bool breed = bool.Parse(bnkdb.GetWCProp(id, StoryProperty.breed));
            var professions = bnkdb.GetWCProfessionsIDs(id);
            var items = bnkdb.GetWCItemsIDs(id);
            string opening = bnkdb.GetWCProp(id, StoryProperty.opening);
            string goodend = bnkdb.GetWCProp(id, StoryProperty.goodend);
            string badend = bnkdb.GetWCProp(id, StoryProperty.badend);

            return new StoryCard(
                id,
                name,
                minplayers,
                breed,
                professions,
                items,
                opening,
                goodend,
                badend
                );
        }

        PlayerCard PlayerCardMethod(int id)
        {
            //todo
            return new PlayerCard();
        }


        //TO-DO: listener..?
    }
}
