﻿using BEL;
using System;
using System.Collections.Generic;
using System.Data.OleDb;


namespace DAL
{
    public class ToolsDBO
    {
        public static bool UpdateTools(Tools ur)
        {
            string requete = String.Format("update Tools set ToolsName='{1}'" +
                " where ToolsID='{0}' ;", ur.ToolsID, ur.ToolsName);

            return Util.miseajour(requete);

        }
        public static bool DeletTools(string id)
        {
            string requete = String.Format("delete * from Tools " +
                " where ToolsID='{0}' ;", id);

            return Util.miseajour(requete);

        }
        public static bool AddTools(Tools ur)
        {
            string requete = String.Format("insert into Tools(ToolsID, ToolsName)" +
                " values ('{0}','{1}');", ur.ToolsID, ur.ToolsName);

            return Util.miseajour(requete);
            //return requete;
        }
        public static bool UpOpenDay(ToolsOpenDay op)
        {
            string requete = String.Format("update ToolsOpenDay set OpenDay='{2}'" +
                "where ((ToolsID='{0}' and YearT>={2}) and WeekT>={3}) ;", op.OpenDay, op.ToolsID, op.YearT, op.WeekT);

            return Util.miseajour(requete);
            //return requete;
        }
        public static bool SetOpenDay(ToolsOpenDay op)
        {
            string requete = String.Format("insert into ToolsOpenDay (ToolsID,YearT,WeekT,OpenDay)  " +
                "values ('{0}',{1},{2},{3});", op.ToolsID, op.YearT, op.WeekT, op.OpenDay);

            return Util.miseajour(requete);

        }
        public static bool UpOperatingNumber(ToolsOpenDay op)
        {
            string requete = String.Format("update ToolsOpenDay set OpenDay={0}" +
                   " where ((ToolsID='{1}' and YearT={2}) and WeekT={3}) ;", op.OpenDay, op.ToolsID, op.YearT, op.WeekT);

            return Util.miseajour(requete);

        }
        public static bool UpAllOperatingNumber(ToolsOpenDay op)
        {
            string requete = String.Format("update ToolsOpenDay set OpenDay={0}" +
                   " where ((ToolsID='{1}' and YearT={2}) and WeekT>={3}) ;", op.OpenDay, op.ToolsID, op.YearT, op.WeekT);

            return Util.miseajour(requete);

        }
        public static List<Tools> GetAllTools()
        {
            List<Tools> Lur = new List<Tools>();
            string requete = String.Format("select * from Tools ;");
            OleDbDataReader rdd = Util.lire(requete);
            Tools ur;
            while (rdd.Read())
            {
                ur = new Tools
                {
                    ToolsID = rdd.GetString(0),

                    ToolsName = rdd.GetString(1),
                };
                Lur.Add(ur);

            }
            Util.Disconnect();
            return Lur;

        }

        public static List<ToolsOpenDay> GetAllToolsOpenDay(string ToID, int yrr, int Wkk)
        {
            List<ToolsOpenDay> Lur = new List<ToolsOpenDay>();
            string requete = String.Format("select * from ToolsOpenDay where (ToolsID='{0}'  and YearT={1}) and WeekT>={2};", ToID, yrr, Wkk);
            OleDbDataReader rdd = Util.lire(requete);
            ToolsOpenDay ur;
            while (rdd.Read())
            {
                ur = new ToolsOpenDay
                {
                    ToolsID = rdd.GetString(0),

                    YearT = rdd.GetInt32(1),
                    WeekT = rdd.GetInt32(2),
                    OpenDay = rdd.GetInt32(3),
                };
                Lur.Add(ur);

            }
            Util.Disconnect();
            return Lur;

        }
        public static Tools GetTools(string id)
        {
            string requete = String.Format("select * from Tools where (ToolsID ='{0}');", id);
            OleDbDataReader rdd = Util.lire(requete);
            Tools ur = new Tools();
            while (rdd.Read())
            {
                ur.ToolsID = rdd.GetString(0);
                ur.ToolsName = rdd.GetString(1);


            }
            Util.Disconnect();
            return ur;

        }

        public static List<Tools> ListToolsOfGrp(string idpostecharge)
        {
            string requete = String.Format("SELECT *" +
                "FROM Tools INNER JOIN((OperationGroupe INNER JOIN Operation ON OperationGroupe.GroupID = Operation.GroupID) INNER JOIN ToolsOccupationTime ON Operation.OperationID = ToolsOccupationTime.OperationID) ON Tools.ToolsID = ToolsOccupationTime.ToolsID where Operation.OperationID = '{0}';", idpostecharge);
            OleDbDataReader rd = Util.lire(requete);


            List<Tools> L = new List<Tools>();
            Tools tools;
            while (rd.Read())
            {
                tools = new Tools
                {
                    ToolsID = rd["Tools.ToolsID"].ToString(),
                    ToolsName = rd["ToolsName"].ToString(),
                };
                L.Add(tools);
            }


            Util.Disconnect();
            return L;
        }
        public static List<DemandeOP> GetDemandeOPTools(string id, int wek)
        {
            List<DemandeOP> Lur = new List<DemandeOP>();
            string requete = String.Format("SELECT sum(DemandeQTE),Operation.OperationID,WeekDem,OccupationTime " +
                "FROM(Product INNER JOIN((Operation INNER JOIN(Tools INNER JOIN ToolsOccupationTime ON Tools.ToolsID = ToolsOccupationTime.ToolsID) " +
    "ON Operation.OperationID = ToolsOccupationTime.OperationID) INNER JOIN ManuelCycleTime ON Operation.OperationID = ManuelCycleTime.OperationID) " +
 "ON Product.ProductID = ManuelCycleTime.ProductID) INNER JOIN Demande ON Product.ProductID = Demande.ProductID  where(Tools.ToolsID = '{0}' " +
 "and WeekDem >= {1}) group by Operation.OperationID,WeekDem,OccupationTime;", id, wek);



            OleDbDataReader rdd = Util.lire(requete);
            DemandeOP ur;
            while (rdd.Read())
            {
                ur = new DemandeOP
                {
                    OperationID = rdd["OperationID"].ToString(),
                    somm = int.Parse(rdd["Expr1000"].ToString()),
                    WeekDem = int.Parse(rdd["WeekDem"].ToString()),
                    CycleTime = float.Parse(rdd["OccupationTime"].ToString()),

                };
                Lur.Add(ur);

            }
            Util.Disconnect();
            return Lur;


        }
        public static List<ToolsOpenDay> GetToolsOpenDay(string machineid, int Wek, int Yr)
        {
            List<ToolsOpenDay> Lur = new List<ToolsOpenDay>();
            string requete = String.Format("select * from ToolsOpenDay where ((ToolsID ='{0}' and WeekT>={1}) and YearT = {2});", machineid, Wek, Yr);
            OleDbDataReader rdd = Util.lire(requete);
            ToolsOpenDay ur;
            while (rdd.Read())
            {
                ur = new ToolsOpenDay
                {
                    ToolsID = rdd.GetString(0),
                    YearT = rdd.GetInt32(1),
                    WeekT = rdd.GetInt32(2),

                    OpenDay = rdd.GetInt32(3),

                };
                Lur.Add(ur);

            }
            Util.Disconnect();
            return Lur;
        }
    }
}
