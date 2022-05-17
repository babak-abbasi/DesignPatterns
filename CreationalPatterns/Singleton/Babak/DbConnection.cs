namespace DesignPatterns.CreationalPatterns.Singleton.Babak
{
    class DbConnection
    {
        private static DbConnection dbConnection;
        private DbConnection() 
        {
        }

        public static DbConnection GetDbConnection() 
        {
            if (dbConnection == null)
                dbConnection = new();

            return dbConnection;
        }
    }
}
