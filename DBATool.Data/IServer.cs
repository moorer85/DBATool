using DBATool.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DBATool.Data
{
    public interface IServer
    {

        IEnumerable<Server> GetAll();

        IEnumerable<Database> GetDatabases(int serverId);

        void Add(Server newServer);

        /////// int GetAssetCount(int branchId);

        Server Get(int id);

    }
}
