namespace TestAPI.Models
{
    public class ResponseModel
    {
        public int Id { get; set; } = 6;
        public string Name { get; set; }
        public ResponseModel()
        {
            Name = "Jacob";
        }
        public string Description { get; set; }
        public bool Check(TestModel testModel)
        {
            if (testModel.Name2 == Name)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
