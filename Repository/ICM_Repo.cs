namespace CM_Login.Repository
{
    public interface ICM_Repo<Content_Manager>
    {
        public List<Content_Manager> GetAllCM();

        public List<Content_Manager> SelectBy_CM_id(int CM_id);
        public void insertCM(Content_Manager C);

        public void UpdateCM(Content_Manager C, int CM_id);


        public bool DeleteCM(int CM_id);


    }
}
