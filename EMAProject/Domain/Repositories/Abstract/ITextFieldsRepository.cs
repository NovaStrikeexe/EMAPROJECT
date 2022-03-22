using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using EMAProject.Domain.Entities;
namespace EMAProject.Domain.Repositories.Abstract
{
    public interface ITextFieldsRepository
    {
         IQueryable<TextField> GetTextFields();
         TextField GetTextFieldById(string id);
         TextField GetTextFieldByCodeWord(string codeWord);
         void SaveTextField(TextField entity);
         
         void DeleteTextField(string id);
    }
}