using Microsoft.AspNetCore.Mvc;
using dotnetcrypto.Models;

namespace dotnetcrypto.Controllers;

[ApiController]
[Route("api/crypto")]
public class CryptoController : ControllerBase
{
   //Entities object
  private readonly CryptodbContext DB;

  public CryptoController(CryptodbContext db)
  {
    this.DB = db;
  }
    
    //to get the data
    [HttpGet("GetAllCrypto")]

    public IQueryable<Cryptogallery> GetAllCrypto()
    {
        try{
            return DB.Cryptogalleries;
        }
        catch(System.Exception)
        {
            throw;
        }
    }

     [HttpGet("GetUserDetailsById/{Cryptoname}")]
    public IActionResult GetByID(string Cryptoname)
    {
            var users =this.DB.Cryptogalleries.FirstOrDefault(o=>o.CryptoName == Cryptoname);
            return Ok(users);
    }
    
}
