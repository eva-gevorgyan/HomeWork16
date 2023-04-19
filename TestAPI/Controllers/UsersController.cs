using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestAPI.Models;

namespace TestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpGet("2222222")]
        public int GetAll()
        {
            return 111;
        }
        [HttpGet("3333333")]
        public int Get333333()
        {
            return 8888;
        }



        [HttpPost("PostAll")]
        public ResponseModel PostAll(TestModel testModel)
        {
            ResponseModel responseModel = new ResponseModel();
            responseModel.Id = testModel.Name1 + 100;
            responseModel.Name = testModel.Name2 + "Testing";
            responseModel.Description = testModel.Name2 + "Testing Description";
            return responseModel;
        }

        [HttpDelete("MinusNumber")]
        public ResponseModelDelete Delete(TestModel testmodel)
        {
            ResponseModelDelete responseModelDelete = new ResponseModelDelete();
            responseModelDelete.Number -= testmodel.Name1 + 150;
            return responseModelDelete;
        }

        [HttpPut("ChangeName2")]
        public TestModel Put(TestModel testModel)
        {
            //TestModel testmodel2 = new TestModel();
            //testmodel2.Name2 = testModel.Name2;
            //testmodel2.Name2 = "Bye";
            //return testmodel2;

            testModel.Name2 = "Bye";
            return testModel;
        }

        [HttpPatch("ChangeOne")]
        public ResponseModel Patch(TestModel testModel)
        {
            ResponseModel responseModel = new ResponseModel();
            if(testModel.Name1 != 0)
            {
                responseModel.Id += testModel.Name1;
            }
            else
            {
                responseModel.Id = 0;
            }
            return responseModel;
        }

        [HttpHead("CheckName")]
        public ResponseModel Head(TestModel testModel)
        {
            ResponseModel responseModel=new ResponseModel();
            if (responseModel.Check(testModel))
            {
                return responseModel;
            }
            else
            {
                responseModel.Name = "Not valid name";
                return responseModel;
            }
        }
    }
}

