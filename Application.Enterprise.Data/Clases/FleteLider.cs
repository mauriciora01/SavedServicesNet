﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;
using Application.Enterprise.CommonObjects;
using System.Reflection;
using System.Diagnostics;

namespace Application.Enterprise.Data
{
    /// <summary>
    /// 
    /// </summary>
    public class FleteLider
    {
        /// <summary>
        /// 
        /// </summary>
        private Database db;
        /// <summary>
        /// Propiedad que contiene el comando para ejecutar el procedimiento almacenado que tiene la funcionalidad para persistir los datos 
        /// </summary>
        private DbCommand commandFlete;

        #region Constructor

        /// <summary>
        /// Constructor de la clase en la que se trae una base de datos distinta a la que hay por defecto
        /// </summary>
        /// <param name="dataBase"> Nombre que contiene la base de datos a utilizar</param>
        public FleteLider(string dataBase)
        {
            DatabaseProviderFactory factory = new DatabaseProviderFactory();
            db = factory.Create(dataBase);
            Config();
        }

        /// <summary>
        /// Constructor de la clase en la que se toma la base de datos por defecto
        /// </summary>
        public FleteLider()
        {
            string dataBase = "conexion"; //TODO: quitar

            db = DatabaseFactory.CreateDatabase(dataBase); //TODO: cambiar a db = DatabaseFactory.CreateDatabase(); por que no se tiene el conexionstrign
            Config();
        }

        /// <summary>
        ///  Metodo para configurar el comando de la DatabaseFactory
        /// </summary>
        private void Config()
        {
            commandFlete = db.GetStoredProcCommand("PRC_SVDN_FLETES_LIDER");

            db.AddInParameter(commandFlete, "i_operation", DbType.String);
            db.AddInParameter(commandFlete, "i_option", DbType.String);
            db.AddInParameter(commandFlete, "i_idlider", DbType.String);
            db.AddInParameter(commandFlete, "i_valor", DbType.Decimal);
            db.AddInParameter(commandFlete, "i_iva", DbType.Int32);
            db.AddInParameter(commandFlete, "i_excluido", DbType.String);
            db.AddInParameter(commandFlete, "i_valorfull", DbType.Decimal);
            db.AddOutParameter(commandFlete, "o_err_cod", DbType.Int32, 1000);
            db.AddOutParameter(commandFlete, "o_err_msg", DbType.String, 1000);

        }
        #endregion

        #region Metodos de Ciudad

        /// <summary>
        /// lista todas los fletes por Lider.
        /// </summary>
        /// <returns></returns>
        public FleteLiderInfo List(string lider)
        {
            db.SetParameterValue(commandFlete, "i_operation", 'S');
            db.SetParameterValue(commandFlete, "i_option", 'A');
            db.SetParameterValue(commandFlete, "i_idlider", lider);

            FleteLiderInfo m = new FleteLiderInfo();

            IDataReader dr = null;

            

            try
            {
                dr = db.ExecuteReader(commandFlete);

                while (dr.Read())
                {
                    m = Factory.GetFlete(dr);

                    
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.WriteLine(string.Format("NIVI Error: {0} , NameSpace: {1}, Clase: {2}, Metodo: {3} ", ex.Message, MethodBase.GetCurrentMethod().DeclaringType.Namespace, MethodBase.GetCurrentMethod().DeclaringType.Name, MethodBase.GetCurrentMethod().Name));

                bool rethrow = ExceptionPolicy.HandleException(ex, "DataAccess Policy");

                if (rethrow)
                {
                    throw;
                }
            }
            finally
            {
                if (dr != null)
                {
                    dr.Close();
                }
            }

            return m;
        }

      

        #endregion
    }
}