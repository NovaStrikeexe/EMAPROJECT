using EMAProject.Domain.Repositories.Abstract;
namespace EMAProject.Domain.Entities
{
    public class SettingsDB:ISettingsDB
    {
        
        public string ServiceItemCollection {get;set;}
        public string TextFieldCollection {get;set;}
        public string ConnectionString { get; set; } = null!;
        public string DatabaseName { get; set; } = null!;
    }
}