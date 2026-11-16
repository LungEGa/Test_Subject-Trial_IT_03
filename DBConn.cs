using System;
using System.Configuration;
using Microsoft.Data.SqlClient;

public class DBConn
{
	private string access_name;
	private string access_credential;
	private string server_location;
	private string database_name;

	public void init()
	{
		this.access_name = ConfigurationManager.AppSettings["access_name"];
        this.access_credential = ConfigurationManager.AppSettings["access_credential"];
        this.server_location = ConfigurationManager.AppSettings["server_location"];
        this.database_name = ConfigurationManager.AppSettings["database_name"];
    }

	public void connect_db() {
		string connect_db_str = $"Server={this.server_location}; Database={this.database_name}; " +
								$"User Id={this.access_name}; Password={this.access_credential}; " +
								$"Encrypted=True; TrustServerCertificate=True;";
	}
}
