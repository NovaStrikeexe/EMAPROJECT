using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;
using EMAProject.Domain.Entities;
using EMAProject.Domain.Repositories;
using EMAProject.Domain.Repositories.Abstract;
namespace EMAProject.Service
{
    public class TextFieldService
    {
        private readonly IMongoCollection<TextField> _textFields;

         public TextFieldService (ISettingsDB settingsDB)
        {
            var client = new MongoClient(settingsDB.ConnectionString);
            var dBase = client.GetDatabase(settingsDB.DatabaseName);

            _textFields = dBase.GetCollection<TextField>(settingsDB.TextFieldCollection);
        }
        /*
        *TODO ТУТ НУЖНО СДЕЛАТЬ ОБРАБОТКУ ОШИБОК 
        */
        public List<TextField> Get() => 
        _textFields.Find(textField => true).ToList();

        public TextField Get(string id) =>
        _textFields.Find<TextField>(textFields => textFields.Id == id).FirstOrDefault();

        public TextField Create(TextField textField)
        {
            _textFields.InsertOne(textField);
            return textField;
        }

        public void Update(string id, TextField textFieldIn)=> 
        _textFields.ReplaceOne(textField=> textField.Id == id, textFieldIn);

         public void Remove(string id)=> 
        _textFields.DeleteOne(textField=> textField.Id == id);
        public void Remove(TextField textFieldIn)=> 
        _textFields.DeleteOne(textField=> textField.Id == textFieldIn.Id);
        
        
    }
}
