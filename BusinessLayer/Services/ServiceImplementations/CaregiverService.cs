using System;
using BusinessLayer.Services.ServiceContracts;
using Entities.BusinessEntities;
namespace BusinessLayer.Services
{
    public class CaregiverService : IDataService<Caregiver>
    {
       
        public int delete(int value)
        {
            return 1;
        }

        public Caregiver get(int id)
        {
            return new Caregiver();
        }

        public Caregiver getAll()
        {
            return new Caregiver();
        }

      
        public int insert(Caregiver value)
        {
            return 1;
        }

      
        public int update(Caregiver value)
        {
            return 1;
        }
    }
}
