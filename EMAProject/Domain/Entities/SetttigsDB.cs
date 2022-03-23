using EMAProject.Domain.Repositories.Abstract;
namespace EMAProject.Domain.Entities
{
    public class SettingsDB:ISettingsDB
    {
        public string ConnectionString { get; set; } = null!;
        public string DatabaseName { get; set; } = null!;
    }
}