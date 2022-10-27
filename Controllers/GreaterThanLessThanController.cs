//Harrison Busby
//10/27/2022
//Greater than or Less than Endpoint
//Peer reviewed by Dan Decoito: The api and program both run well and meets the criteria for the assignment. Good use of if statments

using Microsoft.AspNetCore.Mvc;

namespace BusbyHGreaterThanLessThanEndpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class GreaterThanLessThanController : ControllerBase
{

    [HttpGet]
    [Route("GreaterThanLessThan/{num1}/{num2}")]

    public string GreaterThanLessThan(int num1, int num2){

string result = "";

    
        
            if (num1 > num2)
            {
                result = $"{num1} is greater than {num2} and {num2} is Less than {num1}";
            }
            else if (num1 < num2)
            {
                result = $"{num1} is Less than {num2} and {num2} is greater than {num1}";
            }
            else
            {
               result = $"{num1} Is equal too {num2}";
            }


            return result;
       
    }
    }










