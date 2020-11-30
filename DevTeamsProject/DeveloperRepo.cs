using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeamsProject
{
    public class DeveloperRepo
    {
        private readonly List<Developer> _developerDirectory = new List<Developer>();
        public void AddDeveloperToList(Developer content)//Developer Create
        {
            _developerDirectory.Add(content);
        }
        public List<Developer> GetContentList()//Developer Read
        {
            return _developerDirectory;
        }
        public bool UpdateExistingContent(double originalIdNumber, Developer newContent)//Developer Update
        {
            Developer oldContent = GetContentByIdNumber(originalIdNumber);
            if (oldContent != null)
            {
                oldContent.IdNumber = newContent.IdNumber;
                oldContent.FirstName = newContent.FirstName;
                oldContent.LastName = newContent.LastName;
                oldContent.PluralSightAccess = newContent.PluralSightAccess;
                oldContent.NameOfTeam = newContent.NameOfTeam;
                return true;
            }
            else
            {
                return false;
            }
        }

        private Developer GetContentByIdNumber(double originalIdNumber, object oldContent)
        {
            throw new NotImplementedException();
            if(oldContent != null)
            {

            }
        }

        public bool RemoveContentFromList(double idNumber)//Developer Delete
        {
            Developer content = GetContentByIdNumber(idNumber);
            if(content == null)
            {
                return false;
            }
            int initialCount = _developerDirectory.Count;
            _developerDirectory.Remove(content);

            if (initialCount > _developerDirectory.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private Developer GetContentByIdNumber(double idNumber)//Developer Helper (Get Developer by ID)
        {
            foreach(Developer content in _developerDirectory)
            {
                if(content.IdNumber == idNumber)
                {
                    return content;
                }
            }
            return null;
        }
    }
}
