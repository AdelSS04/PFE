﻿using BEL;
using System;
using System.Collections.Generic;
using System.Data.OleDb;


namespace DAL
{
    public class MachineCycleTimeDBO
    {
        public static List<MachineCycleTime> GetMachineCycleTime(string id)
        {
            string requete = String.Format("select * from MachineCycleTime where (OperationID ='{0}');", id);
            OleDbDataReader rdd = Util.lire(requete);
            List<MachineCycleTime> machCy = new List<MachineCycleTime>();
            MachineCycleTime ur;
            while (rdd.Read())
            {
                ur = new MachineCycleTime
                {

                    MachineID = rdd.GetString(0),
                    CycleTime = float.Parse(rdd.GetString(2)),
                    OperationID = rdd.GetString(1),

                }; machCy.Add(ur);
            }
            Util.Disconnect();
            return machCy;

        }
        public static List<MachineCycleTime> GetOpALLmach(string id)
        {
            string requete = String.Format("select * from MachineCycleTime where (OperationID ='{0}');", id);
            OleDbDataReader rdd = Util.lire(requete);
            List<MachineCycleTime> ur = new List<MachineCycleTime>();
            MachineCycleTime OpMach;
            while (rdd.Read())
            {
                OpMach = new MachineCycleTime()
                {
                    MachineID = rdd.GetString(0),
                    CycleTime = float.Parse(rdd.GetString(2)),
                    OperationID = rdd.GetString(1),
                }; ur.Add(OpMach);


            }
            Util.Disconnect();
            return ur;

        }

        public static bool DeletAllOperationTime(Operation ur)
        {
            string requete = String.Format("delete * from MachineCycleTime where OperationID='{0}' ;", ur.OperationID);

            return Util.miseajour(requete);

        }
        public static bool AddMachineCycleTime(MachineCycleTime ur)
        {
            string requete = String.Format("insert into MachineCycleTime(MachineID, OperationID,CycleTime)" +
                " values ('{0}','{1}','{2}');", ur.MachineID, ur.OperationID, ur.CycleTime);

            return Util.miseajour(requete);
            //return requete;
        }
        public static bool UpMachineCycleTime(MachineCycleTime ur)
        {
            string requete = String.Format("update MachineCycleTime set CycleTime='{2}'" +
                " where MachineID='{0}' and OperationID='{1}' ;", ur.MachineID, ur.OperationID, ur.CycleTime);

            return Util.miseajour(requete);
            //return requete;
        }
        public static bool DeletAllOperationcycleTime(MachineCycleTime ur)
        {
            string requete = String.Format("delete * from MachineCycleTime where OperationID='{0}' and MachineID='{1}' ;", ur.OperationID, ur.MachineID);

            return Util.miseajour(requete);

        }
        public static bool DeletAllMachcycleTime(MachineCycleTime ur)
        {
            string requete = String.Format("delete * from MachineCycleTime where OperationID='{0}' and MachineID='{1}';", ur.OperationID, ur.MachineID);

            return Util.miseajour(requete);

        }

    }
}
