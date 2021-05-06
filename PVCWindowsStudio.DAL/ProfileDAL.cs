﻿using PVCWindowsStudio.BO;
using PVCWindowsStudio.BO.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVCWindowsStudio.DAL
{
    public class ProfileDAL : IRepository<Profiles>, IConvertToObject<Profiles>
    {
        public bool Delete(int id)

        {
            try
            {
                using (var connection = DataConnection.GetConnection())
                {
                    using (var command = DataConnection.Command(connection, "usp_Profile_Delete", CommandType.StoredProcedure))
                    {
                        DataConnection.AddParameter(command, "ProfileID", id);
                        int result = command.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }
            catch
            {
                return false;
            }
        }
        public bool Delete(Profiles model)
        {
            throw new NotImplementedException();
        } 

        public Profiles Get(Profiles model)
        {
            throw new NotImplementedException();
        }

       
        public bool Insert(Profiles model)
        {
            try
            {
                using (var connection = DataConnection.GetConnection())
                {
                    using (var command = DataConnection.Command(connection, "usp_Profile_Insert", CommandType.StoredProcedure))
                    {
                        DataConnection.AddParameter(command, "Name", model.Name);
                        DataConnection.AddParameter(command, "Color", model.Color);
                        DataConnection.AddParameter(command, "Other", model.Other);
                        DataConnection.AddParameter(command, "InsertBy", model.InsertBy);
                        int result = command.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        public Profiles ToObject(SqlDataReader reader)
        {
            Profiles profile = new Profiles
            {
                ProfileID = int.Parse(reader["ProfileID"].ToString()),
                Name = reader["Name"].ToString(),
                NameProf = reader["Name"].ToString() + " " + reader["Color"].ToString(),
                Color = reader["Color"].ToString(),
                Other = reader["Other"].ToString(),
                InsertBy = int.Parse(reader["InsertBy"].ToString()),
                InsertDate = Convert.ToDateTime(reader["InsertDate"].ToString()),
                LUB = int.Parse(reader["LUB"].ToString()),
                LUN = int.Parse(reader["LUN"].ToString()),
                LUD = Convert.ToDateTime(reader["LUD"].ToString())

            };
            return profile;
        }

        

        public bool Update(Profiles model)
        {
            try
            {
                using (var connection = DataConnection.GetConnection())
                {
                    using (var command = DataConnection.Command(connection, "usp_Profile_Update", CommandType.StoredProcedure))
                    {
                        DataConnection.AddParameter(command, "Name", model.Name);
                        DataConnection.AddParameter(command, "Color", model.Color);
                        DataConnection.AddParameter(command, "Other", model.Other);
                        DataConnection.AddParameter(command, "ProfileID", model.ProfileID);
                        DataConnection.AddParameter(command, "LUB", model.LUB);
                        int result = command.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        public Profiles Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Profiles> GetAll()
        {
            try
            {
                List<Profiles> lista = null;
                using (var connection = DataConnection.GetConnection())
                {
                    using (var command = DataConnection.Command(connection, "usp_Profile_GetAll", CommandType.StoredProcedure))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            lista = new List<Profiles>();
                            while (reader.Read())
                            {
                                lista.Add(ToObject(reader));

                            }
                        }
                    }
                }
                return lista;
            }
            catch
            {
                return null;
            }
        }
    }

}
