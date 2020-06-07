namespace BusinessCard.Providers
{
    using BusinessCard.Insfrastructure.Providers;
    using BusinessCard.Options;
    using Microsoft.Extensions.Options;
    using System;

    public class DbConnectionStringProvider : IDbConnectionStringProvider
    {
        private readonly string dbConnectionString;
        public static readonly string DbConnectionString;

        public DbConnectionStringProvider(IOptions<DbConnectionString> options)
        {
            this.dbConnectionString = options.Value.Database;

            GetDbConnectionStringHelper.Instance.DbConnectionString = this.dbConnectionString;
        }

        public string GetConnectionString()
        {
            return this.dbConnectionString;
        }
    }

    public class GetDbConnectionStringHelper
    {
        private static readonly Lazy<GetDbConnectionStringHelper> helper =
            new Lazy<GetDbConnectionStringHelper>(() => new GetDbConnectionStringHelper());

        private string connectionString;

        public string DbConnectionString
        {
            get
            {
                return connectionString;
            }
            set
            {
                if (string.IsNullOrEmpty(connectionString))
                {
                    connectionString = value;
                }
            }
        }

        public static GetDbConnectionStringHelper Instance
        {
            get
            {
                return helper.Value;
            }
        }
    }
}
