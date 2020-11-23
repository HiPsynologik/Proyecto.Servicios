using System.Data;

namespace Proyecto.Servicios.Shared.DbServer
{
    public class DbParameterItem
    {
        public string ParameterNameSP { get; set; }
        public object Value { get; set; }
        public ParameterDirection ParameterDirection { get; set; }
        public int Size { get; set; }
        public DbType DbType { get; set; }
        public DbParameterItem(string parameterName, object value)
        {
            ParameterNameSP = parameterName;
            Value = value;
        }
        public DbParameterItem(string parameterName, object value, ParameterDirection parameterDirection)
        {
            ParameterNameSP = parameterName;
            Value = value;
            ParameterDirection = parameterDirection;
        }
        public DbParameterItem(string parameterName, object value, ParameterDirection parameterDirection, int size, DbType dbType)
        {
            ParameterNameSP = parameterName;
            Value = value;
            ParameterDirection = parameterDirection;
            Size = size;
            DbType = dbType;
        }
    }
}
