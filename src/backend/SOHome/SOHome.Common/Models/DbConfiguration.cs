namespace SOHome.Common.Models;

public class DbConfiguration
{
    public DbConfiguration(string host, string username, string password, string name, params string[] additionalParams)
    {
        var additionalParamsString = string.Join(";", additionalParams);
        ConnectionString = $"Server={host};Port=5432;Database={name};User Id={username};Password={password};{additionalParamsString}";
    }
    public DbConfiguration(string host, int port, string username, string password, string name, params string[] additionalParams)
    {
        var additionalParamsString = string.Join(";", additionalParams);
        ConnectionString = $"Server={host};Port={port};Database={name};User Id={username};Password={password};{additionalParamsString}";
    }
    public DbConfiguration(string connectionString)
    {
        ConnectionString = connectionString;
    }
    public string ConnectionString { get; }
}