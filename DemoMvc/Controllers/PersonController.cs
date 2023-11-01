using DemoMvc.Person;
using Microsoft.AspNetCore.Mvc;

public class PersonController : Controller
{
    public IActionResult IndexPerson()
    {
        return View();
    }
    [HttpPost]
    public IActionResult IndexPerson(Person ps)
    {
        string strResult = "Xin chao " + ps.PersonID + "-" + ps.FullName + "-" + ps.Address;
        ViewBag.capnhat = strResult;    
        return View();
    }
}
