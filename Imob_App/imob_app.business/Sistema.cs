using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace imob_app.business
{
    public class Sistema
    {
        #region Atributos
        /// <summary>
        /// Represents the user logged on the system.
        /// </summary>
        protected string userId;

        /// <summary>
        /// Represents the user logged on the system.
        /// </summary>
        public string UserId
        {
            get
            {
                return this.userId;
            }
        }
        #endregion

        #region Construtor
		/// <summary>
		/// Initializes an instance of System Manager object;
		/// </summary>
		/// <param name="user">The user logged on the system.(ex: Facebook ID)</param>
		public Sistema(string userId)
		{
            this.userId = userId;
		}
		#endregion

        #region Unhandled Exceptions
        /// <summary>
        /// Registers an unhandled Exception into the database. If it fails, registers
        /// into the EventViewer.
        /// </summary>
        /// <param name="system">The system name</param>
        /// <param name="user">The logged user</param>
        /// <param name="e">The unhandled exception</param>
        /// <returns>The id that corresponds with the stored event.</returns>
        public string RegistrarErro (Exception e)
        {
            string retorno = "";
            try
            {
                // TODO WITH Entities
                //DataAccess.EntryPoint da = new DataAccess.EntryPoint(Enum.DataBase.BasicInfo);
                //da.AddParameter("P_DT_EVENT", DateTime.Now);
                ////da.AddParameter("P_ID_SYSTEM", ConfigurationManager.AppSettings["FrameworkSystemCode"]);
                //da.AddParameter("P_LOGIN", this.login);
                //da.AddParameter("P_DS_EVENT", e.Message);
                //da.AddParameter("P_DS_STACK_TRACE", e.StackTrace);
                //da.AddParameter("P_DS_SOURCE", (e.TargetSite == null) ? "null" : e.TargetSite.ToString());
                //da.AddParameter("P_ID_EVENT", 1, MW_ERP.Basic_Framework.Enum.ParameterDirection.Output);
                //da.ExecNonQuery("PR_IN_SYSTEM_ERROR_EVENT");
                //returnValue = da.GetParameterValue("P_ID_EVENT").ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return retorno;
        }
        #endregion
    }
}
