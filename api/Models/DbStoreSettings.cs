namespace api.Models
{
	public class DbStoreSettings : IDbStoreSettings
	{
		public string ProductsCollectionName { get; set; }
		public string ConnectionString { get; set; }
		public string DatabaseName { get; set; }
	}

	public interface IDbStoreSettings
	{
		string ProductsCollectionName { get; set; }
		string ConnectionString { get; set; }
		string DatabaseName { get; set; }
	}
}