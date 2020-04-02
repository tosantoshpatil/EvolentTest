using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
  public interface IcontactRepository:IDisposable
    {
        IEnumerable<ContactInfo> GetContactInfos();
        ContactInfo Add(ContactInfo contactInfo);
        ContactInfo GetById(int ContactId);
        void UpdateContactInfo(ContactInfo contactInfo);
        void DeleteContact(int ContactInfoId);
        void InActivatedContact(int ContactInfoId);

    }
}
