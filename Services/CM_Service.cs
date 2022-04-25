using System;
using CM_Login.Repository;
using CM_Login.Models;


namespace CM_Login.Services
{
    public class CM_Service
    {

        private readonly ICM_Repo<Content_Manager> cms = new CM_Repo();

        public CM_Service()
        { }
        public CM_Service(ICM_Repo<Content_Manager> CM)
        {
            cms = CM;
        }

        public List<Content_Manager> GetAllCM()
        {
            return cms.GetAllCM();
        }

        public void insertCM(Content_Manager C)
        {
            cms.insertCM(C);    
        }

        public void UpdateCM(Content_Manager C, int CM_id)
        {
            cms.UpdateCM(C, CM_id); 
        }

        public bool DeleteCM(int Admin_id)
        {
            bool i = cms.DeleteCM(Admin_id);   
            return i;
        }

        public List<Content_Manager> Select_CM_By_id(int Admin_id)
        {
            return cms.SelectBy_CM_id(Admin_id);

        }


    }

}

