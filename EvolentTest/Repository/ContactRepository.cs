using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ContactRepository : IcontactRepository
    {
        public ContactInfo Add(ContactInfo contactInfo)
        {
            try
            {
                using (TestEntities testEntities = new TestEntities())
                {
                    testEntities.ContactInfoes.Add(contactInfo);
                    testEntities.SaveChanges();
                    return contactInfo;
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public ContactInfo GetById(int ContactId)
        {
            try
            {
                using (TestEntities testEntities = new TestEntities())
                {
                    return testEntities.ContactInfoes.Where(c => c.ContactId == ContactId).FirstOrDefault();
                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        public void DeleteContact(int ContactInfoId)
        {
            try
            {
                using (TestEntities testEntities = new TestEntities())
                {
                    ContactInfo contactInfo= testEntities.ContactInfoes.Where(c => c.ContactId == ContactInfoId).FirstOrDefault();

                    testEntities.ContactInfoes.Remove(contactInfo);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public IEnumerable<ContactInfo> GetContactInfos()
        {
            try
            {
                using (TestEntities testEntities = new TestEntities())
                {
                    return testEntities.ContactInfoes.ToList();
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public void UpdateContactInfo(ContactInfo contactInfo)
        {
            try
            {
                using (TestEntities testEntities = new TestEntities())
                {
                    testEntities.Entry(contactInfo).State = EntityState.Modified;
                    testEntities.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void InActivatedContact(int ContactInfoId)
        {
            using (TestEntities test = new TestEntities())
            {
                ContactInfo contactInfo = test.ContactInfoes.Where(c => c.ContactId == ContactInfoId).FirstOrDefault();
                if (contactInfo != null)
                {
                    contactInfo.Status = false;
                    test.Entry(contactInfo).State = EntityState.Modified;
                    test.SaveChanges();
                }
             }
        }

    
    }
}

