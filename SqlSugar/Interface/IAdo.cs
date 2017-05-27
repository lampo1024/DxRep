﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SqlSugar
{
    public partial interface IAdo
    {
        string SqlParameterKeyWord { get; }
        IDbConnection Connection { get; set; }
        IDbTransaction Transaction { get; set; }
        IDataParameter[] ToIDbDataParameter(params SugarParameter[] pars);
        SugarParameter[] GetParameters(object obj, PropertyInfo[] propertyInfo = null);
        SqlSugarClient Context { get; set; }
        void ExecLogEvent(string sql, SugarParameter[] pars, bool isStarting = true);

        IConnectionConfig MasterConnectionConfig { get; set; }
        List<IConnectionConfig> SlaveConnectionConfigs { get; set; }

        CommandType CommandType { get; set; } 
        bool IsEnableLogEvent { get; set; }
        Action<string, string> LogEventStarting { get; set; }
        Action<string, string> LogEventCompleted { get; set; }
        bool IsClearParameters { get; set; }
        int CommandTimeOut { get; set; }
        IDbBind DbBind { get; }
        void SetCommandToAdapter(IDataAdapter adapter,IDbCommand command);
        IDataAdapter GetAdapter();
        IDbCommand GetCommand(string sql, SugarParameter[] pars);
        DataTable GetDataTable(string sql, object pars);
        DataTable GetDataTable(string sql, params SugarParameter[] pars);
        DataTable GetDataTable(string sql, List<SugarParameter> [] pars);
        DataSet GetDataSetAll(string sql, object pars);
        DataSet GetDataSetAll(string sql, params SugarParameter[] pars);
        DataSet GetDataSetAll(string sql, List<SugarParameter> pars);
        IDataReader GetDataReader(string sql,object pars);
        IDataReader GetDataReader(string sql, params SugarParameter[] pars);
        IDataReader GetDataReader(string sql,List<SugarParameter> pars);
        object GetScalar(string sql, object pars);
        object GetScalar(string sql, params SugarParameter[] pars);
        object GetScalar(string sql,List<SugarParameter> pars);
        int ExecuteCommand(string sql, object pars);
        int ExecuteCommand(string sql, params SugarParameter[] pars);
        int ExecuteCommand(string sql, List<SugarParameter> pars);
        string GetString(string sql, object pars);
        string GetString(string sql, params SugarParameter[] pars);
        string GetString(string sql, List<SugarParameter> pars);
        int GetInt(string sql, object pars);
        int GetInt(string sql, params SugarParameter[] pars);
        int GetInt(string sql, List<SugarParameter> pars);
        Double GetDouble(string sql,object pars);
        Double GetDouble(string sql, params SugarParameter[] pars);
        Double GetDouble(string sql,List<SugarParameter> pars);
        decimal GetDecimal(string sql, object pars);
        decimal GetDecimal(string sql, params SugarParameter[] pars);
        decimal GetDecimal(string sql, List<SugarParameter> pars);
        DateTime GetDateTime(string sql, object pars);
        DateTime GetDateTime(string sql, params SugarParameter[] pars);
        DateTime GetDateTime(string sql, List<SugarParameter> pars);
        List<T> SqlQuery<T>(string sql, object whereObj = null);
        List<T> SqlQuery<T>(string sql, params SugarParameter[] pars);
        List<T> SqlQuery<T>(string sql, List<SugarParameter>  pars);
        void Dispose();
        void Close();
        void Open();
        void CheckConnection();

         void BeginTran();
         void BeginTran(IsolationLevel iso);
         void BeginTran(string transactionName);
         void BeginTran(IsolationLevel iso, string transactionName);
         void RollbackTran();
         void CommitTran();
    }
}
