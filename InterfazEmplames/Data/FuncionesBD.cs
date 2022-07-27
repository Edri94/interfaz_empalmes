﻿using InterfazEmplames.Helpers;
using InterfazEmplames.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace InterfazEmplames.Data
{
    public class FuncionesBD : ConexionBD
    {
        public ConexionBD cnnConexion;
        SqlConnection connection;
        public String connectionString;
        Encriptacion encriptacion;

        string gsCataDB;
        string gsDSNDB;
        string gsSrvr;
        string gsUserDB;
        string gsPswdDB;
        string gsNameDB;

        public int registros_procesados;

        public FuncionesBD(string cnn) : base(cnn)
        {
            encriptacion = new Encriptacion();
            cnnConexion = new ConexionBD(cnn);
            this.connectionString = cnn;


        }

        public int ejecutarInsert(string query)
        {
            try
            {
                cnnConexion.ActiveConnection = true;
                cnnConexion.ParametersContains = false;
                cnnConexion.CommandType = CommandType.Text;
                cnnConexion.ActiveConnection = true;

                int afectados = cnnConexion.ExecuteNonQuery(query);

                return afectados;
            }
            catch (Exception ex)
            {
                Log.Escribe(ex);
                return -1;
            }
        }

        public int ejecutarDelete(string query)
        {
            try
            {
                cnnConexion.ActiveConnection = true;
                cnnConexion.ParametersContains = false;
                cnnConexion.CommandType = CommandType.Text;
                cnnConexion.ActiveConnection = true;

                int afectados = cnnConexion.ExecuteNonQuery(query);

                return afectados;
            }
            catch (Exception ex)
            {
                Log.Escribe(ex);
                return -1;
            }
        }


        public int transaccionInsert(List<QueryParametro> querys)
        {
            registros_procesados = 0;
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                connection.Open();

                SqlCommand command = connection.CreateCommand();
                SqlTransaction transaction;

                transaction = connection.BeginTransaction("transaccionInsert");

                command.Connection = connection;
                command.Transaction = transaction;


                try
                {

                    foreach (QueryParametro query in querys)
                    {
                        command.Parameters.Clear();
                        command.CommandText = query.Query;
                        foreach (SqlParameter parametro in query.Parametros)
                        {
                            command.Parameters.Add(parametro);
                        }
                        registros_procesados++;
                        //if (registros_procesados > 3) break; //[pruebas]
                        command.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    Log.Escribe("records are written to database.");
                    return registros_procesados;
                }
                catch (Exception ex)
                {
                    Log.Escribe("Commit Exception");
                    Log.Escribe(ex);
                    try
                    {
                        transaction.Rollback();
                        return -1;
                    }
                    catch (Exception ex2)
                    {
                        Log.Escribe("Rollback Exception");
                        Log.Escribe(ex2);
                        return -1;
                    }
                }
            }
        }

        public List<Map> LLenarMapToQuery(List<Map> maps, SqlDataReader dr)
        {
            try
            {
                if (dr.FieldCount == 1)
                {
                    while (dr.Read())
                    {
                        switch (maps[0].Type)
                        {
                            case "string":
                                maps[0].Value = dr.GetString(0);
                                break;

                            case "int":
                                maps[0].Value = dr.GetInt32(0);
                                break;

                            default:
                                maps[0].Value = dr.GetString(0);
                                break;
                        }

                    }
                }
                dr.Close();
                return maps;
            }
            catch (Exception ex)
            {
                Log.Escribe(ex);
                dr.Close();
                return null;
            }

        }

        public Map LLenarMapToQuery(Map mapa, SqlDataReader dr)
        {
            try
            {
                if (dr.FieldCount == 1)
                {
                    while (dr.Read())
                    {
                        switch (mapa.Type)
                        {
                            case "string":
                                mapa.Value = dr.GetString(0);
                                break;

                            case "int":
                                mapa.Value = dr.GetInt32(0);
                                break;

                            case "smallint":
                                mapa.Value = dr.GetInt16(0);
                                break;

                            default:
                                mapa.Value = dr.GetString(0);
                                break;
                        }

                    }
                }
                dr.Close();
                return mapa;
            }
            catch (Exception ex)
            {
                Log.Escribe(ex);
                dr.Close();
                return null;
            }

        }

        public SqlDataReader ejecutarConsulta(string query)
        {
            try
            {
                cnnConexion.ActiveConnection = true;
                cnnConexion.ParametersContains = false;
                cnnConexion.CommandType = CommandType.Text;
                cnnConexion.ActiveConnection = true;

                SqlDataReader sqlRecord = cnnConexion.ExecuteDataReader(query);

                return sqlRecord;
            }
            catch (Exception ex)
            {
                Log.Escribe(ex);
                return null;
            }
        }

        public SqlDataReader ejecutarConsultaParametros(string query, SqlParameter[] sqlParameters)
        {
            SqlDataReader sqlRecord;
            try
            {
                cnnConexion.ActiveConnection = true;
                cnnConexion.ParametersContains = true;
                cnnConexion.CommandType = CommandType.Text;
                cnnConexion.ActiveConnection = true;
                cnnConexion.AddParameters(sqlParameters);

                sqlRecord = cnnConexion.ExecuteDataReader(query);

                return sqlRecord;
            }
            catch (Exception ex)
            {
                Log.Escribe(ex);
                return null;
            }

        }

        public int ejecutarActualizacionParametros(string query, SqlParameter[] sqlParameters)
        {
            int afectados = 0;
            try
            {
                cnnConexion.ActiveConnection = true;
                cnnConexion.ParametersContains = true;
                cnnConexion.CommandType = CommandType.Text;
                cnnConexion.ActiveConnection = true;
                cnnConexion.AddParameters(sqlParameters);

                afectados = cnnConexion.ExecuteNonQuery(query);
            }
            catch (Exception ex)
            {
                Log.Escribe(ex);
            }

            return afectados;

        }

        /// <summary>
        /// Obtener fecha del servidor SQL
        /// </summary>
        /// <param name="con_hora">Se desea saber la fecha con hora o no</param>
        /// <returns></returns>
        public string ObtenerFechaServidor(bool con_hora = false)
        {
            try
            {
                string query;

                if (con_hora)
                {
                    query = "select FORMAT(GETDATE(), 'yyyy-MM-dd hh:mm:ss')  as [fecha_actual]";
                }
                else
                {
                    query = "select FORMAT(GETDATE(), 'yyyy-MM-dd')  as [fecha_actual]";
                }

                SqlDataReader dr = ejecutarConsulta(query);

                string fecha_actual = string.Empty;

                while (dr.Read())
                {
                    fecha_actual = dr.GetString(0);
                }
                dr.Close();
                return fecha_actual;
            }
            catch (Exception ex)
            {
                return DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            }
        }
    }


}

